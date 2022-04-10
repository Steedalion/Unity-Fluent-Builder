using System;
using System.Collections;
using NUnit.Framework;
using UnityEditor.PackageManager;
using UnityEngine.UIElements;

namespace Systems.Tests.TestBuilders.com.longtailgames.fluentbuilder.Tests
{
    public class InstallTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void InstallTestsSimplePasses()
        {
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        // [UnityTest]
        public IEnumerator InstallTestsWithEnumeratorPasses()
        {
            var request = Client.Add("https://github.com/Steedalion/com.longatilgames.fluentbuilder.git");
            while (!request.IsCompleted)
            {
                yield return null;
            }

            Console.WriteLine("Error is" + request.Error);
            Assert.IsNull(request.Error);
        }

        // [UnityTest]
        public IEnumerator RemovePackage()
        {
            yield return InstallTestsWithEnumeratorPasses();
            var request = Client.Remove("https://github.com/Steedalion/com.longatilgames.fluentbuilder.git");
            while (!request.IsCompleted)
            {
                yield return null;
            }

            Console.WriteLine("Error is" + request.Error);
            Assert.IsNull(request.Error);
        }
    }
}