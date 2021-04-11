module Program41

//41.4.1. Напишите функцию list_filter, которая реализует стандартную функцию List.filter, с помощью List.foldBack
let list_filter f xs = 
    let foldFunc x acc = if (f(x)) then x::acc else acc
    List.foldBack foldFunc xs []

// 41.4.2. Напишите функцию sum(p, xs), где p -- предикат int -> bool, и xs -- список целых.
//Функция возвращает сумму тех элементов xs, для которых предикат истинен.
//Реализуйте sum с помощью List.fold или List.foldBack.
let sum (p, xs) = 
    let foldFunc acc x = if (p x) then (acc + x) else acc
    List.fold foldFunc 0 xs

// 41.4.3. Напишите функцию revrev, которая получает на вход список списков, и перевёртывает как порядок вложенных списков, так и порядок элементов внутри каждого вложенного списка.
let revrev = fun xs ->
    let foldFunc x tail = (List.rev tail)::x
    List.fold foldFunc xs 
    

