module Program20

//20.3.1. Напишите функцию vat: int -> float -> float, так что vat n x увеличивает x на n процентов (0 <= n <= 100)
let vat (n:int) (x:float) = x + (float)n / (float)100 * x

//20.3.2. Напишите функцию unvat: int -> float -> float такую, что unvat n (vat n x) = x
let unvat (n:int) (x:float) = (float)100 / (float)(100 + n) * x

//20.3.3. Напишите функцию min: (int -> int) -> int, так что min(f) вычисляет минимальное целое положительное число n, когда f(n) = 0. Подразумевается, что такое натуральное число существует всегда.
let rec min f = 
    let rec iterate n = 
        if f(n) = 0 then n else iterate(n + 1)
    iterate 1
