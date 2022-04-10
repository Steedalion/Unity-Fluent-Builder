using System.Collections;
using UnityEngine;

namespace com.longtailgames.fluentbuilder.Systems.Tests.TestBuilders.com.longtailgames.fluentbuilder.Runtime
{
    public static class A
    {
        public static ComponentBuilder go => new ComponentBuilder();
  
        public static IEnumerator DestroyAllExistingGameObjects()
        {
            foreach (GameObject gameObject in Object.FindObjectsOfType<GameObject>())
            {
                Object.Destroy(gameObject);
                yield return null;
            }

        }
    }
}