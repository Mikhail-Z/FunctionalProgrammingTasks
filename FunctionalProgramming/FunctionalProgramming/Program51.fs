module Program51

type 'a cell = Nil | Cons of 'a * Lazy<'a cell>

let hd (s : 'a cell) : 'a =
  match s with
    Nil -> failwith "hd"
  | Cons (x, _) -> x

let tl (s : 'a cell) : Lazy<'a cell> =
  match s with
    Nil -> failwith "tl"
  | Cons (_, g) -> g


// 51.3
let rec nth (s : 'a cell) (n : int) : 'a =
  let rec nthIter (s: 'a cell) (i: int): 'a =
    if i = n then hd s
    else nthIter ((tl s).Force()) (i+1)
  nthIter s 0