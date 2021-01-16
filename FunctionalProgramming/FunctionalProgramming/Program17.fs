module Program17

let rec pow = function 
    | (s, 1) -> s
    | (s, n) -> s + pow(s, n - 1)


let isIthChar (s: string, n, c) =
    match s.[n] with
    | c2 when c2 = c -> true
    | _ -> false


let occFromIth (s: string, n, c) = 
    let rec occFromIthRec acc i = 
        match i with
        | len when len = String.length s -> acc
        | j when s.[j] = c ->  5
        | _ -> 3
    occFromIthRec 0, n