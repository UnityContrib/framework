using System.Collections;
using System.Reflection;
using UnityEngine;
using QTree = UnityContrib.UnityEngine.Quadtree<UnityEngine.Vector3>;
using Random = UnityEngine.Random;

namespace RobinTheilade
{
    public class QuadtreeRemoveTest : MonoBehaviour
    {
        private void Awake()
        {
            var boundaries = new Rect(
                0.0f,
                0.0f,
                2000.0f,
                2000.0f
                );

            var tree = new QTree(boundaries);

            var positions = new Vector3[25];

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
            for (var index = 0; index < positions.Length; index++)
            {
                var position = positions[index];
                tree.Insert(position, position);
            }

            // empty tree
            for (var index = 0; index < positions.Length; index++)
            {
                var position = positions[index];
                tree.Remove(position, position);

                var valueCount = CountValues(tree);
                if (valueCount != tree.Count)
                {
                    Debug.LogError("Wrong Tree.Count. Expected: " + valueCount + " Actual: " + tree.Count);
                    return;
                }

                if (valueCount != positions.Length - index - 1)
                {
                    Debug.LogError("Expected: " + valueCount + " Actual: " + (positions.Length - index - 1));
                    return;
                }
            }

            Debug.Log("Done, no errors encountered.");
        }

        private static int CountValues(QTree tree)
        {
            var count = 0;
            var type = tree.GetType();

            var nodesListField = type.GetField("nodes", BindingFlags.Instance | BindingFlags.NonPublic);
            var nodesListValue = nodesListField.GetValue(tree) as IList;
            if (nodesListValue != null)
            {
                count += nodesListValue.Count;
            }

            var childrenArrayField = type.GetField("children", BindingFlags.Instance | BindingFlags.NonPublic);
            var childrenArrayValue = childrenArrayField.GetValue(tree) as QTree[];
            if (childrenArrayValue != null)
            {
                foreach (var childTree in childrenArrayValue)
                {
                    count += CountValues(childTree);
                }
            }

            return count;
        }
    }
}
