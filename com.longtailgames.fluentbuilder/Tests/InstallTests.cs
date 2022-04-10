using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.TestTools;

public class InstallTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void InstallTestsSimplePasses()
    {
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator InstallTestsWithEnumeratorPasses()
    {
        var request = Client.Add("https://github.com/Steedalion/com.longatilgames.fluentbuilder.git");
        while (!request.IsCompleted)
        {
            yield return null;
        }

        Console.WriteLine("Error is"+request.Error);
        Assert.IsNull(request.Error);
    }
}