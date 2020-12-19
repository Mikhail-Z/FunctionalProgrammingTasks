// Learn more about F# at http://fsharp.org
module Program431_432

open System

//4.3.1 Напишите программу, выводящую строку "Hello, World!!!"
printfn "Hello, World!!!"

//4.3.2. Напишите программу, вычисляющую и выводящую на экран значение выражения 2.1 + 3.2 * (8 / 4 + 1.3)
let calculate = 2.1 + 3.2 * (float (8 / 4) + 1.3);
printfn "%f" calculate