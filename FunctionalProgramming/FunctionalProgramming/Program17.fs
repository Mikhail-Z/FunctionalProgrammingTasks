module Program17

let rec pow (s, n) = 
    match n with
    | 1 -> s
    | _ -> s + pow(s, n - 1)


let rec isIthChar(s: string, n, c) =
    match s.[n] with
    | c2 when c2 = c -> true
    | _ -> false

let rec occFromIthRec(s: string, c, i, acc) = 
    match i with
    | len when len = String.length s -> acc
    | j when s.[j] = c -> occFromIthRec(s, c, i + 1, acc + 1)
    | _ -> occFromIthRec(s, c, i + 1, acc)

let rec occFromIth(s,n,c) = occFromIthRec(s, n, c, 0)