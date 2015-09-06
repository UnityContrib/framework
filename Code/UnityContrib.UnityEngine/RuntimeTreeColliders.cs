﻿using System.Collections.Generic;
using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Positions tree colliders near the player.
    /// </summary>
    /// <remarks>
    /// The trees used on the terrain must contain a capsule collider defining the tree trunk.
    /// The player is found using the "Player" tag.
    /// The colliders are parented to the terrain in the hierarchy.
    /// </remarks>
    [AddComponentMenu("Physics/Runtime Tree Colliders")]
    [RequireComponent(typeof(Terrain))]
    public class RuntimeTreeColliders : MonoBehaviour
    {
        /// <summary>
        /// The length of the diagonal of the square that defines the area around the player to look for trees.
        /// A high number might result in performance issues.
        /// A low number might result in trees that can be passed through.
        /// </summary>
        [Tooltip("The length of the diagonal of the square that defines the area around the player to look for trees.\nA high number might result in performance issues.\nA low number might result in trees that can be passed through.")]
        public float diagonalLength = 10.0f;

        /// <summary>
        /// The maximum number of colliders to create.
        /// A high number might result in performance issues.
        /// A low number might result in trees that can be passed through.
        /// </summary>
        [Tooltip("The maximum number of colliders to create.\nA high number might result in performance issues.\nA low number might result in trees that can be passed through.")]
        public int maxColliders = 20;

        /// <summary>
        /// The player the colliders must follow.
        /// </summary>
        [Tooltip("The transform the colliders must follow around.")]
        public Transform player;

        /// <summary>
        /// A reference to the terrain component.
        /// </summary>
        private Terrain terrain;

        /// <summary>
        /// A reference to the terrain data.
        /// </summary>
        private TerrainData data;

        /// <summary>
        /// The position when the colliders were last changed.
        /// </summary>
        private Vector3 lastChangePosition;

        /// <summary>
        /// The colliders managed by this component.
        /// </summary>
        private readonly List<CapsuleCollider> colliders = new List<CapsuleCollider>();

        /// <summary>
        /// The tree instance info components attached to the colliders.
        /// </summary>
        private readonly List<TreeInstanceInfo> infos = new List<TreeInstanceInfo>();

        /// <summary>
        /// Quadtree for fast lookup by the player's position.
        /// </summary>
        private Quadtree<TreeInstance> trees;

        /// <summary>
        /// Half the length of <see cref="F:diagonalLength"/>.
        /// </summary>
        private float diagonalLengthOver2;

        /// <summary>
        /// Caches quick references and initializes the quadtree.
        /// </summary>
        /// <remarks>
        /// This method is invoked by Unity.
        /// </remarks>
        private void Start()
        {
            this.diagonalLengthOver2 = this.diagonalLength * 0.5f;

            this.terrain = this.GetComponent<Terrain>();
            this.data = terrain.terrainData;

            var boundaries = new Rect(
                this.terrain.transform.position.x,
                this.terrain.transform.position.z,
                this.data.size.x,
                this.data.size.z
                );
            this.trees = new Quadtree<TreeInstance>(boundaries);
            foreach (var instance in this.data.treeInstances)
            {
                this.AddTree(instance);
            }
        }

        /// <summary>
        /// Changes the colliders based on which trees the player is near.
        /// </summary>
        /// <remarks>
        /// This method is invoked by Unity.
        /// </remarks>
        private void FixedUpdate()
        {
            var playerPosition = this.player.position;
            var delta = playerPosition - this.lastChangePosition;

            // don't use Vector3.Distance or Vector3.magnitude as
            // we in this case prefer performance over precision
            var approxDistance = delta.sqrMagnitude;
            if (approxDistance < this.diagonalLengthOver2)
            {
                return;
            }

            this.lastChangePosition = playerPosition;

            var colliderIndex = 0;
            CapsuleCollider currentCollider;
            TreeInstanceInfo treeInstanceInfo;

            // define the square around the player in which we want to look for trees
            var range = new Rect(
                playerPosition.x - this.diagonalLengthOver2,
                playerPosition.z - this.diagonalLengthOver2,
                this.diagonalLength,
                this.diagonalLength
                );

            var instances = this.trees.Find(range);
            foreach (var instance in instances)
            {
                if (colliderIndex < this.colliders.Count)
                {
                    currentCollider = this.colliders[colliderIndex];
                    treeInstanceInfo = currentCollider.GetComponent<TreeInstanceInfo>();
                }
                else
                {
                    var gameObject = new GameObject("Tree Collider");
                    gameObject.transform.parent = this.transform;
                    currentCollider = gameObject.AddComponent<CapsuleCollider>();
                    treeInstanceInfo = gameObject.AddComponent<TreeInstanceInfo>();
                    this.colliders.Add(currentCollider);
                    this.infos.Add(treeInstanceInfo);
                }

                var prototype = this.data.treePrototypes[instance.prototypeIndex];
                var prototypeCollider = prototype.prefab.GetComponent<CapsuleCollider>();

                // update transform
                currentCollider.transform.position = new Vector3(
                    instance.position.x * this.data.size.x + this.terrain.transform.position.x,
                    instance.position.y * this.data.size.y + this.terrain.transform.position.y,
                    instance.position.z * this.data.size.z + this.terrain.transform.position.z
                    );
                currentCollider.transform.localScale = Vector3.one * instance.widthScale;

                // setup collider
                this.CopyCapsuleColliderProperties(prototypeCollider, currentCollider);

                this.SetupChildColliders(currentCollider, prototypeCollider);

                // activate!
                currentCollider.gameObject.SetActive(true);

                treeInstanceInfo.treeInstance = instance;
                treeInstanceInfo.terrain = this.terrain;

                colliderIndex++;

                if (colliderIndex > this.maxColliders)
                {
                    Debug.LogError("Generating colliders for too many trees, skipping");
                    break;
                }
            }

            for (var index = colliderIndex; index < this.colliders.Count; index++)
            {
                var collider = this.colliders[index];
                collider.gameObject.SetActive(false);
            }
        }

        /// <summary>
        /// Creates, updates, enables and disables child colliders.
        /// </summary>
        /// <param name="currentCollider">
        /// The parent collider.
        /// </param>
        /// <param name="prototypeCollider">
        /// The prototype collider containing the child colliders to base the child colliders on.
        /// </param>
        private void SetupChildColliders(CapsuleCollider currentCollider, CapsuleCollider prototypeCollider)
        {
            var currentChildIndex = 0;

            for (var prototypeChildIndex = 0; prototypeChildIndex < prototypeCollider.transform.childCount; prototypeChildIndex++)
            {
                var prototypeChildTransform = prototypeCollider.transform.GetChild(prototypeChildIndex);
                var prototypeChildCollider = prototypeChildTransform.GetComponent<CapsuleCollider>();
                if (prototypeChildCollider == null)
                {
                    continue;
                }

                GameObject currentChildGameObject;
                Transform currentChildTransform;

                if (currentCollider.transform.childCount > currentChildIndex)
                {
                    currentChildTransform = currentCollider.transform.GetChild(currentChildIndex);
                    currentChildGameObject = currentChildTransform.gameObject;
                }
                else
                {
                    currentChildGameObject = new GameObject("Child Tree Collider", typeof(CapsuleCollider));
                    currentChildTransform = currentChildGameObject.transform;
                    currentChildTransform.parent = currentCollider.transform;
                }

                var currentChildCollider = currentChildTransform.GetComponent<CapsuleCollider>();

                this.CopyCapsuleColliderProperties(prototypeChildCollider, currentChildCollider);

                currentChildTransform.position = prototypeChildTransform.position + currentCollider.transform.position;
                currentChildTransform.rotation = prototypeChildTransform.rotation;
                currentChildTransform.localScale = prototypeChildTransform.localScale;

                currentChildGameObject.SetActive(true);

                currentChildIndex++;
            }

            while (currentCollider.transform.childCount > prototypeCollider.transform.childCount)
            {
                var currentChildTransform = currentCollider.transform.GetChild(currentChildIndex);
                var currentChildGameObject = currentChildTransform.gameObject;
                currentChildGameObject.SetActive(false);

                currentChildIndex++;
            }
        }

        /// <summary>
        /// Copies the capsule collider specific properties from one <see cref="T:UnityEngine.CapsuleCollider"/> to another.
        /// </summary>
        /// <param name="from">
        /// The <see cref="T:UnityEngine.CapsuleCollider"/> containing the properties to copy.
        /// </param>
        /// <param name="to">
        /// The <see cref="T:UnityEngine.CapsuleCollider"/> to apply the properties to.
        /// </param>
        private void CopyCapsuleColliderProperties(CapsuleCollider from, CapsuleCollider to)
        {
            to.radius = from.radius;
            to.height = from.height;
            to.center = from.center;
            to.direction = from.direction;
            to.material = from.material;
        }

        /// <summary>
        /// Adds the specified <paramref name="treeInstance"/>
        /// to the collection of trees who's collider to manage.
        /// </summary>
        /// <param name="treeInstance">
        /// The <see cref="T:UnityEngine.TreeInstance"/> to add.
        /// </param>
        public bool AddTree(TreeInstance treeInstance)
        {
            var x = treeInstance.position.x * this.data.size.x + this.terrain.transform.position.x;
            var z = treeInstance.position.z * this.data.size.z + this.terrain.transform.position.z;
            return this.trees.Insert(x, z, treeInstance);
        }

        /// <summary>
        /// Removes the specified <paramref name="treeInstance"/>
        /// from the collection of trees who's collider to manage.
        /// </summary>
        /// <param name="treeInstance">
        /// The <see cref="T:UnityEngine.TreeInstance"/> to remove.
        /// </param>
        public bool RemoveTree(TreeInstance treeInstance)
        {
            // disable collider to avoid colliding with a tree that doesn't exist
            for (var index = 0; index < this.infos.Count; index++)
            {
                var treeInstanceInfo = this.infos[index];
                if (treeInstance.Same(treeInstanceInfo.treeInstance))
                {
                    treeInstanceInfo.gameObject.SetActive(false);
                    break;
                }
            }

            // remove the tree itself
            var x = treeInstance.position.x * this.data.size.x + this.terrain.transform.position.x;
            var z = treeInstance.position.z * this.data.size.z + this.terrain.transform.position.z;
            return this.trees.Remove(x, z, treeInstance);
        }
    }
}
