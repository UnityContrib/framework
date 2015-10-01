using System.Collections;
using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides helper methods for working with the <see cref="T:System.Collections.IEnumerator"/> class.
    /// </summary>
    public static class IEnumeratorEx
    {
        /// <summary>
        /// Enumerates the specified <paramref name="enumerator"/> recursively.
        /// 
        /// If the <paramref name="enumerator"/> returns another 
        /// <see cref="T:System.Collections.IEnumerator"/> that will also be enumerated an so forward.
        /// </summary>
        /// <param name="enumerator">
        /// The <see cref="T:System.Collections.IEnumerator"/> to enumerate.
        /// </param>
        /// <param name="maxRecursion">
        /// The maximum number of recursion levels before aborting.
        /// </param>
        /// <param name="currentRecursion">
        /// The current number of recursion levels.
        /// </param>
        /// <returns>
        /// The values of the enumeration(s).
        /// </returns>
        public static IEnumerator Recursive(this IEnumerator enumerator, int maxRecursion = 7, int currentRecursion = 0)
        {
            if (currentRecursion > maxRecursion)
            {
                Debug.LogError("Reached maxRecursion value of " + maxRecursion);
                yield break;
            }

            while (enumerator.MoveNext())
            {
                var childEnumerator = enumerator.Current as IEnumerator;
                if (childEnumerator != null)
                {
                    var recursiveEnumerator = childEnumerator.Recursive(maxRecursion, currentRecursion + 1);
                    while (recursiveEnumerator.MoveNext())
                    {
                        var childResult = recursiveEnumerator.Current;
                        yield return childResult;
                    }
                }

                yield return null;
            }
        }
    }
}
