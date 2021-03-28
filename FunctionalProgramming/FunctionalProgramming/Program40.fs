module Program40

let rec sum p xs = match xs with
    |   [] -> 0
    |   x::tail -> if (p x) then x + sum p tail else sum p tail


let rec count (xs, n) = match xs with
    |   [] -> 0
    |   head::tail -> if (head < n) then count (tail, n) elif (head = n) then 1 + count (tail, n) else 0


let rec insert (xs, n) = match xs with
|   [] -> [n]
|   head::tail -> if (head < n) then head::insert (tail, n) else head::(n::tail)


let rec intersect (xs1, xs2) = match (xs1, xs2) with
    |   (head1::tail1, head2::tail2) when head1 < head2 -> intersect (tail1, head2::tail2)
    |   (head1::tail1, head2::tail2) when head1 > head2 -> intersect (head1::tail1, tail2)
    |   (head1::tail1, head2::tail2) when head1 = head2 -> head1::intersect (tail1, tail2)
    |   _ -> []


let rec plus (xs1, xs2) = match (xs1, xs2) with
|   (head1::tail1, head2::tail2) when head1 < head2 -> head1::plus (tail1, head2::tail2)
|   (head1::tail1, head2::tail2) when head1 > head2 -> head2::plus (head1::tail1, tail2)
|   (head1::tail1, head2::tail2) when head1 = head2 -> head1::(head2::plus (tail1, tail2))
|   ([], head::tail) -> head::tail
|   (head::tail, []) -> head::tail
|   _ -> []


let rec minus (xs1, xs2) = match (xs1, xs2) with
|   (head1::tail1, head2::tail2) when head1 < head2 -> head1::minus (tail1, head2::tail2)
|   (head1::tail1, head2::tail2) when head1 > head2 -> minus (head1::tail1, tail2)
|   (head1::tail1, head2::tail2) when head1 = head2 -> minus (tail1, tail2)
|   ([], _) -> []
|   (head::tail, []) -> head::tail
|   _ -> []


let rec smallest xs =
    let rec smallestInternal (xs, curMin) = match xs with
    |   [] -> Some curMin
    |   head::tail -> if head < curMin then smallestInternal (tail, head) else smallestInternal (tail, curMin)

    match xs with
    |   [] -> None
    |   head::tail -> smallestInternal (tail, head)


let rec delete (n, xs) = match xs with
    |   [] -> []
    |   head::tail -> if (head = n) then tail else head::delete (n, tail)


let rec sort = fun xs -> 
    let min = smallest xs
    if (min.IsSome) then min::sort (delete (min.Value, xs)) else []


let rec revrev = fun xs ->
    let rec rev xss = match xss with
    |   [] -> []
    |   head::tail -> (rev tail)@[head] 

    match xs with
    |   [] -> []
    |   head::tail -> (revrev tail)@[rev head]
