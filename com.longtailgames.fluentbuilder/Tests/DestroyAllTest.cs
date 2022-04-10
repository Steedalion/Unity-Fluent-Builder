using System.Collections;
using System.Collections.Generic;
using com.longtailgames.fluentbuilder.Systems.Tests.TestBuilders.com.longtailgames.fluentbuilder.Runtime;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Systems.Tests.TestBuilders.com.longtailgames.fluentbuilder.Tests
{
    public class DestroyAllTest
    {
        [UnityTest]
        public IEnumerator DestroyOne()
        {
            GameObject go = new GameObject();
            yield return null;
            Assert.NotNull(go);
            yield return A.DestroyAllExistingGameObjects();
            Assert.True(go==null);
        }

        [UnityTest]
        public IEnumerator DestroyMany()
        {
            var gos = new List<GameObject>();
            for (int i = 0; i < 10; i++)
            {
                var go = A.go.Build();
                gos.Add(go);
                yield return null;
                Assert.NotNull(go);
            }
            yield return A.DestroyAllExistingGameObjects();
            foreach (GameObject o in gos)
            {
                Assert.True(o==null);
            }
        }
    }
}