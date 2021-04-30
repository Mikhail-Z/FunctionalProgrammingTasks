module Program43

//43.3. Задание Реализуйте стандартную функцию Map.tryFind самостоятельно в виде функции try_find.
let try_find key m = 
    let rec try_get lst = 
        match lst with
        |   [] -> None
        |   (k, value)::tail -> if k = key then Some(value) else try_get tail
    let r = Map.toList m
    try_get r