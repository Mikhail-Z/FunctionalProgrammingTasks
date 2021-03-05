module Program34

//34.1. Напишите функцию upto: int -> int list, которая работает так:
//upto n = [1; 2; ...; n].
let rec uptorec n m = match n with
|   0 -> []
|   s -> m :: uptorec (s - 1) (m + 1)

let rec upto n = uptorec n 1


//34.2. Напишите функцию dnto: int -> int list, которая работает так:
//downto n = [n; n-1; n-2; ...; 1]
let rec dnto n = match n with
    |   0 -> []
    |   m -> m :: dnto (m - 1)

//34.3. Напишите функцию evenn: int -> int list, которая генерирует список из первых n неотрицательных чётных чисел.
let rec evennrec n m = match n with
|   0 -> []
|   _ -> match m % 2 with
    |   0 -> m :: evennrec (n - 1) (m + 1)
    |   _ -> evennrec (n - 1) (m + 1)

let rec evenn n = evennrec (n + 1) 0