using UnityEngine;

namespace UnityContrib.UnityEngine
{
    /// <summary>
    /// Provides a set of helper methods for working with the <see cref="T:UnityEngine.NavMeshAgent"/> class.
    /// </summary>
    public static class NavMeshAgentEx
    {
        /// <summary>
        /// Returns a value indicating whether or not the specified <paramref name="agent"/> is planning or following a path.
        /// </summary>
        /// <param name="agent">
        /// The agent to query.
        /// </param>
        /// <returns>
        /// true if the agent is planning or following a path; otherwise false.
        /// </returns>
        public static bool IsNavigating(this NavMeshAgent agent)
        {
            return agent.hasPath || agent.pathPending;
        }
    }
}
