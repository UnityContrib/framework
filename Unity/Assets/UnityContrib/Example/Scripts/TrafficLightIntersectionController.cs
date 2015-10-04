using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityContrib.UnityEngine;
using UnityEngine;

public class TrafficLightIntersectionController : MonoBehaviour
{
    [SerializeField]
    private string pattern = "ABCD";

    private void Start()
    {
        this.StartCoroutine(this.Process().Recursive());
    }

    private IEnumerator Process()
    {
        if(string.IsNullOrEmpty(this.pattern))
        {
            Debug.LogError("Pattern not specified");
            yield break;
        }
        var patternChars = this.pattern.ToCharArray();

        var trafficLights = GameObject.FindObjectsOfType<TrafficLight>();
        var states = new Dictionary<char, List<TrafficLight>>();
        trafficLights.ForEach(t =>
        {
            var name = t.name;
            var index = name.IndexOf('-');
            if(index == -1)
            {
                return;
            }

            var groupString = name.Substring(index + 1);
            foreach (var groupChar in groupString)
            {
                if(states.ContainsKey(groupChar))
                {
                    states[groupChar].Add(t);
                }
                else
                {
                    var list = new List<TrafficLight>()
                    {
                        t,
                    };
                    states.Add(groupChar, list);
                }
            }

            t.Set(false, false, true);
        });

        List<TrafficLight> previousState = null;

        while (Application.isPlaying)
        {
            yield return this.Wait(2.0f);

            foreach (var patternChar in patternChars)
            {
                var currentState = states[patternChar];
                using (new TimelineLog("TrafficLightIntersectionController", "States", patternChar.ToString()))
                {
                    if (previousState != null)
                    {
                        var red = previousState.Where(lhs => !currentState.Any(rhs => lhs == rhs));
                        yield return this.SwithToRed(red);
                        yield return this.Wait(2.0f);
                    }

                    yield return this.SwithToGreen(currentState);
                    yield return this.Wait(5.0f);
                }

                previousState = currentState;
            }
        }
    }

    private IEnumerator SwithToGreen(IEnumerable<TrafficLight> trafficLights)
    {
        // don't switch those that are aleady green
        trafficLights = trafficLights.Where(t => !t.IsGreen);

        using (new TimelineLog("TrafficLightIntersectionController", "State", "Swithing to green"))
        {
            trafficLights.ForEach(t => t.Set(false, false, true));
            yield return null;

            trafficLights.ForEach(t => t.Set(false, true, true));
            yield return this.Wait(2.0f);

            trafficLights.ForEach(t => t.Set(true, false, false));
        }
    }

    private IEnumerator Wait(float seconds)
    {
        using (new TimelineLog("TrafficLightIntersectionController", "State", "Waiting"))
        {
            var end = Time.time + seconds;
            while(end > Time.time)
            {
                yield return null;
            }
        }
    }

    private IEnumerator SwithToRed(IEnumerable<TrafficLight> trafficLights)
    {
        using (new TimelineLog("TrafficLightIntersectionController", "State", "Swithing to red"))
        {
            trafficLights.ForEach(t => t.Set(true, false, false));
            yield return null;

            trafficLights.ForEach(t => t.Set(false, true, false));
            yield return this.Wait(2.0f);

            trafficLights.ForEach(t => t.Set(false, false, true));
        }
    }
}
