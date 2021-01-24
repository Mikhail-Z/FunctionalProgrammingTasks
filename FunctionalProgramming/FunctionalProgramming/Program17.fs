//17.4.1. Напишите функцию pow: string * int -> string, где pow(s,n) выдаёт строку s, повторенную n раз.
let rec pow = function 
    | (_, 0) -> ""
    | (s, 1) -> s
    | (s, n) -> s + pow(s, n - 1)

//17.4.2. Напишите функцию-предикат isIthChar: string * int * char -> bool, где isIthChar(s,n,c) проверяет, равен ли n-й (начиная с нуля) символ строки s символу c.
let isIthChar (s: string, n, c: char) =
    match n with
    | m when m < 0 || m >= s.Length -> false
    | m when s.[m] = c -> true
    | _ -> false

//17.4.3. Напишите функцию occFromIth: string * int * char -> int, где occFromIth(s,n,c) возвращает количество вхождений символа с в строке s, начиная с позиции n.
let occFromIth (s: string, n, c) = 
    let rec occFromIthRec acc i = 
        match i with
        | len when len = String.length s -> acc
        | j when s.[j] = c ->  occFromIthRec (acc + 1) (i + 1)
        | _ -> occFromIthRec acc (i + 1)
    occFromIthRec 0 n