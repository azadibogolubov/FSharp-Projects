open System
(* Factorial Function *)
let rec factorial x = if x < 1 then 1 else x * factorial (x - 1)
Console.WriteLine("The factorial of 10 is: ")
Console.WriteLine(factorial 10)

(* Add the first n numbers *)
let rec addToN n = if n = 1 then 1 else n + addToN (n - 1)
Console.WriteLine("The sum of the first 5 numbers is: ")
Console.WriteLine(addToN 5

(* List of squares for 1 up to 10 *)
let listOfSquares = [ for i in 1 .. 10 -> i*i ]
Console.WriteLine("Squares up to 10:")
Console.WriteLine(listOfSquares)

(* List of evens from 1 up to 10 *)
let evens = [ for i in 1 .. 10 do if i % 2 = 0 then yield i ]
Console.WriteLine("Positive evens up to 10:")
Console.WriteLine(evens))
