# Design Patterns - Adapter Pattern

The adapter pattern converts the interface of a class into another interface the client expects.
This pattern is used when an existing class expects an object of a certain interface and lets classes work together that couldn't otherwise.

In this example a client invokes the accelerate method on an ICar. Using the BikeAdapter, an IBike can be *adapted* so that the same invoke method can be used on the IBike.
