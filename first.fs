// Import the System namespace
open System

// Variables
let x = 5
let y = 10
let z = x + y

// The following will throw an error:
// Uncomment the followig two lines to create an error.
//let a = "let makes immutable variables, like const in C++"
//let a = "trying to change will break the variable.

// Print statements
printfn "x: %i" x
printfn "y: %i" y
printfn "z: %i" z

// Function definitions
// Function to return the sign of the number provided
let sign num = if num > 0 then "positive" elif num < 0 then "negative" else "zero"

// Function to return the square of the number provided
let square x = x * x

// Alternate print statements, like C#
Console.Write("sign 5: ")
Console.WriteLine(sign 5)

Console.Write("sign -5: ")
Console.WriteLine(sign -5)

Console.Write("sign 0: ")
Console.WriteLine(0)

Console.Write("square -5: ")
Console.WriteLine(square -5)

Console.Write("square 5: ")
Console.WriteLine(square 5)

Console.Write("square 0: ")
Console.WriteLine(square 0)
