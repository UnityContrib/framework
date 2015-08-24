using UnityContrib.UnityEngine;
using UnityEngine;
using Random = UnityEngine.Random;

namespace UnityContrib
{
    /// <summary>
    /// Tests the speed of adding, querying and removing elements in the tree.
    /// </summary>
    public class QuadtreeSpeedTest : MonoBehaviour
    {
        private void Awake()
        {
            var boundaries = new Rect(
                0.0f,
                0.0f,
                2000.0f,
                2000.0f
                );

            var tree = new Quadtree<Vector3>(boundaries);

            var positions = new Vector3[1000000];

            // generate random vectors
            for (var index = 0; index < positions.Length; index++)
            {
                positions[index] = new Vector3(
                    Random.value * 2000.0f,
                    Random.value * 2000.0f,
                    Random.value * 2000.0f
                    );
            }

            // fill tree
            Measure.DebugLogTime("Fill", () =>
            {
                for (var index = 0; index < positions.Length; index++)
                {
                    var position = positions[index];
                    tree.Insert(position, position);
                }
            });

            // query tree
            Measure.DebugLogTime("Query", () =>
            {
                for (var index = 0; index < positions.Length; index++)
                {
                    var range = new Rect(
                        Random.value * 2000.0f,
                        Random.value * 2000.0f,
                        10.0f,
                        10.0f
                        );
                    tree.Find(range);
                }
            });

            // empty tree
            Measure.DebugLogTime("Remove", () =>
            {
                for (var index = 0; index < positions.Length; index++)
                {
                    var position = positions[index];
                    tree.Remove(position, position);
                }
            });
        }
    }
}
