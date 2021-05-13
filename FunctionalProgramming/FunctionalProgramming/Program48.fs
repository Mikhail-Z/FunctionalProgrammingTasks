module Program48

let rec fibo1 n n1 n2 = 
    match n with
    |   0 -> 0
    |   1 -> 1
    |   2 -> n1 + n2
    |   _ -> fibo1 (n-1) (n1+n2) n1

let rec fibo2 c n = 
    match n with
    |   0 -> c 0
    |   1 -> c 1
    |   _ -> (fibo2 (fun x -> c x) (n-1) + fibo2 (fun x -> c x) (n-2))


let rec bigList n k =
    let rec f n acc = 
        if n = 0 then acc
        else f (n-1) (1::acc)
    
    f n []
