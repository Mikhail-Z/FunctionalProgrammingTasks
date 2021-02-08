module Program21


(*Задание

Даны две функции

curry: (int * int -> int) -> int -> int ->int

и

uncurry: (int -> int ->int) -> int * int -> int
curry f -- это функция g, где g x -- это функция h, где h y = f(x,y).

uncurry g -- это функция f, где f(x,y) -- это значение h y для функции h = g x.

Напишите их реализации.
*)

let curry f = fun x y -> f(x, y)
let uncarry f = fun (x, y) -> f(x) y
