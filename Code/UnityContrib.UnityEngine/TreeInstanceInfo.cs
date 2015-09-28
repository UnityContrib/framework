using System;
using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a reference to the tree that was collided with.
    /// </summary>
    [AddComponentMenu("Physics/Runtime Tree Colliders - Tree Instance Info")]
    [RequireComponent(typeof(CapsuleCollider))]
    public class TreeInstanceInfo : MonoBehaviour
    {
        /// <summary>
        /// The reference to the tree that was collided with.
        /// </summary>
        [Tooltip("The current tree the collider is applied to.")]
        [SerializeField]
        private TreeInstance treeInstance;

        /// <summary>
        /// The reference to the terrain the tree belongs to.
        /// </summary>
        [Tooltip("The terrain the tree belongs to.")]
        [SerializeField]
        private Terrain terrain;

        /// <summary>
        /// Gets the prototype of the tree.
        /// </summary>
        public TreePrototype TreePrototype
        {
            get
            {
                return this.Terrain.terrainData.treePrototypes[this.TreeInstance.prototypeIndex];
            }
        }

        /// <summary>
        /// Gets the index of the instance in the <see cref="F:UnityEngine.TerrainData.treeInstances"/> array.
        /// </summary>
        public int TreeInstanceIndex
        {
            get
            {
                return Array.FindIndex(
                    Terrain.terrainData.treeInstances,
                    i => i.Same(TreeInstance)
                    );
            }
        }

        /// <summary>
        /// Gets or sets the reference to the tree that was collided with.
        /// </summary>
        public TreeInstance TreeInstance
        {
            get
            {
                return treeInstance;
            }

            set
            {
                treeInstance = value;
            }
        }

        /// <summary>
        /// Gets or sets the reference to the terrain the tree belongs to.
        /// </summary>
        public Terrain Terrain
        {
            get
            {
                return terrain;
            }

            set
            {
                terrain = value;
            }
        }
    }
}
