using System.Collections;
using UnityEngine;

namespace com.longtail.fluentBuilder.Systems.Tests.TestBuilders.Runtime
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