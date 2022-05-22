# Fluent Builder

A small unity library convenient for runtime tests.


String together the construction of a gameobject, its components and position.

`var go = A.go.With<Rigidbody>().Build();`

Mostly used for testing 
```

    [UnityTest]
        public IEnumerator MulitAtAndWithA()
        {
            Gameobject gameobject = A.go
                .With<Rigidbody>()
                .With<BoxCollider>() //string together multiple components.
                .At(Vector3.up)
                .Build();
            yield return null;
            Assert.AreEqual(Vector3.up.y, go.transform.position.y, .01f);
        }
```

Use unity package manager. Unity -> Packages -> Add package from git URL -> enter http url.


<img src=upm.png , align=left>
