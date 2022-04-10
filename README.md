# Fluent Builder

A small unity library convienient for runtime tests.


String together the construction of a gameobject, its components and position.


`var go = A.go.With<Rigidbody>().With<BoxCollider>().At(Vector3.up).Build();`
