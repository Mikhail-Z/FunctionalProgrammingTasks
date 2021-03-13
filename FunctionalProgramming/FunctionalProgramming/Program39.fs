module Program35

let rec rmodd2 list i = match list with
    |   [] -> []
    |   head::tail -> match i % 2 with
        |   1 ->  head :: rmodd2 tail (i + 1)
        |   0 ->  rmodd2 tail (i + 1)

//39.1. Напишите функцию rmodd, которая получает на вход список, и выдаёт список, в который 
//входят значения входного списка на нечётных позициях (первая позиция в списке, с индексом 0, считается чётной).
let rec rmodd list = rmodd2 list 0

//39.2. Напишите функцию del_even, которая получает на вход список, и выдаёт список, из которого удалены все
//чётные значения входного списка.
let rec del_even list = match list with
|   [] -> []
|   head::tail -> match head % 2 with
    |   1 ->  head :: del_even tail
    |   0 ->  del_even tail

//39.3. Напишите функцию multiplicity x xs, которая находит, сколько раз значение x встречается в списке xs.
let rec multiplicity x xs = match xs with
    |   [] -> 0
    |   head::tail -> (if head = x then 1 else 0) + multiplicity x tail


let rec rmodd3 list i = match list with
|   [] -> []
|   head::tail -> match i % 2 with
    |   0 ->  head :: rmodd3 tail (i + 1)
    |   1 ->  rmodd3 tail (i + 1)

//39.4. Напишите функцию split, которая разделяет входной список на два следующим образом:
let rec split list = match list with
    |   [] -> ([], [])
    |   _ -> (rmodd3 list 0, rmodd2 list 0)

//39.5. Напишите функцию zip, которая преобразует два входных списка в результирующий список следующим образом
let rec zip (xs1,xs2) = match (xs1, xs2) with
    |   ([], []) -> []
    |   (head1::tail1, head2::tail2) -> (head1, head2) :: zip (tail1, tail2)
