module Program81

//16.1. Напишите функцию-предикат notDivisible: int * int -> bool, где notDivisible(n,m) возвращает true, если число n -- делитель числа m.
let notDivisible (n, m) = 
    match m % n with
    | 0 -> false
    | _ -> true


let rec prime2 (n, m) = 
    match m with
    | 1 -> true
    | _ -> match n % m with
        | 0 -> false
        | _ -> prime2(n, m - 1)


//16.2. Напишите функцию-предикат prime: int -> bool, где prime(n) возвращает true, если n -- простое число.
let prime (n) = 
    match n with 
    | 1 -> false
    | _ -> prime2(n, n / 2)
