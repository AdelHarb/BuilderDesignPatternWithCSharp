# BuilderDesignPatternWithCSharp

# This is a simple example of the Builder Design Pattern with C#.

# This example is based on Passionate Coders Youtube Channel: https://www.youtube.com/watch?v=51Ap3s__P_Q

Builder Pattern is a Creational Design Pattern that allows us to create complex object
for example object with many parameters beside that, some parameters could be optional.

object that may do heavy I/O operations or object that may take long time to be created.

so Builder Pattern helps to delay the creation of the object. so when cancellation is requested,
    not many resources being wasted.

# Implementation

Create a class that contains all the parameters of the object as private fields.

For every parameter, create a public method that sets the value of the parameter and returns the instance of the class
    so we can chain the methods by fluent API.

# Rest of the Explanation in the Program.cs file.
