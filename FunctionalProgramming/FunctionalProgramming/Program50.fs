module Program50

// 50.2.1
let rec factorial n =
    match n with
    | 0 | 1 -> 1
    | _ -> n * factorial(n-1)
    
let fac_seq = seq {
    let mutable i = 0
    while true do
        yield factorial i
        i <- i + 1
}

// 50.2.2
let seq_seq = seq {
    let mutable i = 0
    yield i
    while true do
        i <- i + 1
        yield! [-i; i]
}