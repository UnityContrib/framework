using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Values for placing random trees.
    /// </summary>
    /// <remarks>
    /// <see cref="T:UnityContrib.UnityEditor.MassTreePlacementEditor"/> does the actual work.
    /// </remarks>
    [AddComponentMenu("Terrain/Mass Tree Placement")]
    [RequireComponent(typeof(Terrain))]
    public class MassTreePlacement : MonoBehaviour
    {
#pragma warning disable 0414 // The field 'XYZ' is assigned but never used

        /// <summary>
        /// The number of trees to place.
        /// </summary>
        [Tooltip("The number of trees to place.")]
        [SerializeField]
        private int count = 70000;

        /// <summary>
        /// The lowest point to position a tree.
        /// </summary>
        [Tooltip("The lowest point to position a tree.")]
        [SerializeField]
        private float minWorldY = 1.0f;

        /// <summary>
        /// The highest point to position a tree.
        /// </summary>
        [Tooltip("The highest point to position a tree.")]
        [SerializeField]
        private float maxWorldY = 5200.0f;

        /// <summary>
        /// The minimum allowed slope of the ground to position a tree.
        /// </summary>
        [Tooltip("The minimum allowed slope of the ground to position a tree.")]
        [SerializeField]
        private float minSlope = 0.0f;

        /// <summary>
        /// The maximum allowed slope of the ground to position a tree.
        /// </summary>
        [Tooltip("The maximum allowed slope of the ground to position a tree.")]
        [SerializeField]
        private float maxSlope = 40.0f;

        /// <summary>
        /// The minimum value to scale the width of a tree.
        /// </summary>
        [Tooltip("The minimum value to scale the width of a tree.")]
        [SerializeField]
        private float minWidthScale = 0.9f;

        /// <summary>
        /// The maximum value to scale the width of a tree.
        /// </summary>
        [Tooltip("The maximum value to scale the width of a tree.")]
        [SerializeField]
        private float maxWidthScale = 2.0f;

        /// <summary>
        /// The minimum value to scale the height of a tree.
        /// </summary>
        [Tooltip("The minimum value to scale the height of a tree.")]
        [SerializeField]
        private float minHeightScale = 0.8f;

        /// <summary>
        /// The maximum value to scale the height of a tree.
        /// </summary>
        [Tooltip("The maximum value to scale the height of a tree.")]
        [SerializeField]
        private float maxHeightScale = 3.5f;

        /// <summary>
        /// The maximum number of seconds for the placement process to take.
        /// The process is aborted if it takes any longer.
        /// </summary>
        [Tooltip("The maximum number of seconds for the placement process to take. The process is aborted if it takes any longer.")]
        [SerializeField]
        private double maxTime = 30.0d;

#pragma warning restore 0414 // The field 'XYZ' is assigned but never used

        /// <summary>
        /// Gets or sets the number of trees to place.
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        /// <summary>
        /// Gets or sets the lowest point to position a tree.
        /// </summary>
        public float MinWorldY
        {
            get
            {
                return minWorldY;
            }

            set
            {
                minWorldY = value;
            }
        }

        /// <summary>
        /// Gets or sets the highest point to position a tree.
        /// </summary>
        public float MaxWorldY
        {
            get
            {
                return maxWorldY;
            }

            set
            {
                maxWorldY = value;
            }
        }

        /// <summary>
        /// Gets or sets the minimum allowed slope of the ground to position a tree.
        /// </summary>
        public float MinSlope
        {
            get
            {
                return minSlope;
            }

            set
            {
                minSlope = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum allowed slope of the ground to position a tree.
        /// </summary>
        public float MaxSlope
        {
            get
            {
                return maxSlope;
            }

            set
            {
                maxSlope = value;
            }
        }

        /// <summary>
        /// Gets or sets the minimum value to scale the width of a tree.
        /// </summary>
        public float MinWidthScale
        {
            get
            {
                return minWidthScale;
            }

            set
            {
                minWidthScale = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum value to scale the width of a tree.
        /// </summary>
        public float MaxWidthScale
        {
            get
            {
                return maxWidthScale;
            }

            set
            {
                maxWidthScale = value;
            }
        }

        /// <summary>
        /// Gets or sets the minimum value to scale the height of a tree.
        /// </summary>
        public float MinHeightScale
        {
            get
            {
                return minHeightScale;
            }

            set
            {
                minHeightScale = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum value to scale the height of a tree.
        /// </summary>
        public float MaxHeightScale
        {
            get
            {
                return maxHeightScale;
            }

            set
            {
                maxHeightScale = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum number of seconds for the placement process to take.
        /// The process is aborted if it takes any longer.
        /// </summary>
        public double MaxTime
        {
            get
            {
                return maxTime;
            }

            set
            {
                maxTime = value;
            }
        }
    }
}
