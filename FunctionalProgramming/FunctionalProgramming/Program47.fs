module Program47

// 47.4.1
// Напишите функцию факториала f: int -> int, не используя рекурсию, с помощью императивных возможностей.
let f n =
    let mutable acc = 1
    let accumulate x = acc <- acc * x 
    let lst = List.ofSeq {1..n}
    List.iter accumulate lst
    acc

// 47.4.2
//Напишите функцию fibo: int -> int, где fibo(n) вычисляет n-е число Фибоначчи (n >= 0), не используя рекурсию, с помощью императивных возможностей.
//Последовательность Фибоначчи начинается с двух значений 0,1, а n-й элемент равен сумме n-1 - го и n-2 - го элементов: 0,1,1,2,3,5,8,13,...
let fibo n = 
    let mutable prevprev = 0
    let mutable prev = 1
    let mutable acc = 0
    
    let fib() =
        acc <- prev + prevprev
        prevprev <- prev
        prev <- acc
        
    match n with
    |   1 -> acc <- prevprev
    |   2 -> acc <- prev
    |   _ -> for i = 3 to n + 1 do fib()

    acc