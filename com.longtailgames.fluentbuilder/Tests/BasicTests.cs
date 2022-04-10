using System.Collections;
using com.longtailgames.fluentbuilder.Systems.Tests.TestBuilders.com.longtailgames.fluentbuilder.Runtime;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Systems.Tests.TestBuilders.com.longtailgames.fluentbuilder.Tests
{
    public class BasicTests
    {
        [UnitySetUp]
        public IEnumerator DestroyAll()
        {
            yield return A.DestroyAllExistingGameObjects();
        }
        [UnityTest]
        public IEnumerator ImplicitlyCastsToGameobject()
        {
            GameObject go = A.go;
            yield return null;
            Assert.AreEqual(go.GetType(), typeof(GameObject));
        }

        [UnityTest]
        public IEnumerator ExplicitBuildsGAMEobject()
        {
            var go = A.go.Build();
            yield return null;
            Assert.AreEqual(go.GetType(), typeof(GameObject));
        }

        [UnityTest]
        public IEnumerator ExplicitBuildWithComponentCreatesGO()
        {
            var go = A.go.With<Rigidbody>().Build();
            yield return null;
            Assert.AreEqual(go.GetType(), typeof(GameObject));
        }

        [UnityTest]
        public IEnumerator WithAReturnsComponent()
        {
            var component = A.go.WithA<Rigidbody>();
            yield return null;
            Assert.AreEqual(component.GetType(), typeof(Rigidbody));
        }

        [UnityTest]
        public IEnumerator GOWithMultipleComponents()
        {
            var go = A.go.With<Rigidbody>().With<BoxCollider>().Build();
            yield return null;
            Assert.NotNull(go.GetComponent<BoxCollider>());
            Assert.NotNull(go.GetComponent<Rigidbody>());
        }

        [UnityTest]
        public IEnumerator GoMulitWithABuildsAll()
        {
            BoxCollider go = A.go.With<Rigidbody>().WithA<BoxCollider>();
            yield return null;
            Assert.NotNull(go.transform.GetComponent<BoxCollider>());
            Assert.NotNull(go.transform.GetComponent<Rigidbody>());
        }

        [UnityTest]
        public IEnumerator GoCreatedAtPosition()
        {
            var go = A.go.At(Vector3.up * 10).Build();
            yield return null;
            Assert.AreEqual(go.transform.position.y, (Vector3.up * 10).y, 0.01f);
        }

        [UnityTest]
        public IEnumerator MulitAtAndWithA()
        {
            var go = A.go.With<Rigidbody>().With<BoxCollider>().At(Vector3.up).Build();
            yield return null;
            Assert.NotNull(go.GetComponent<Rigidbody>());
            Assert.NotNull(go.GetComponent<BoxCollider>());
            Assert.AreEqual(Vector3.up.y, go.transform.position.y, .01f);
        }
    }
}