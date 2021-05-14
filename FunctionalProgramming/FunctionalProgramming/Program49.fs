module Program49

let even_seq = Seq.initInfinite (fun x -> 2 * (x+1))

let rec factorial n =
    match n with
    | 0 | 1 -> 1
    | _ -> n * factorial(n-1)
let fac_seq = Seq.initInfinite factorial

let seq_seq = Seq.initInfinite (fun x -> if x = 0 then 0 elif x % 2 = 1 then -x/2-1 else x/2)
