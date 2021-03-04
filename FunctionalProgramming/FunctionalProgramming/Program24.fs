module Program24

type TimeOfDay = { hours: int; minutes: int; f: string }

//24.4. Задание
//Время дня может быть представлено тройкой (часы, минуты, половина дня), где часы принимают значение в диапазоне от 0 до 11, минуты -- от 0 до 59, и половина дня -- это либо "AM" (первые 12 часов), либо "PM" (вторые 12 часов).
//Реализуйте инфиксный оператор .>. , который сравнивает два корректных значения типа TimeOfDay
let (.>.) x y =
    match x.f.CompareTo(y.f) with
    |   1 -> true
    |   -1 -> false
    |   0 -> match x.hours.CompareTo(y.hours) with
        |   1 -> true
        |   -1 -> false
        |   0 -> match x.minutes.CompareTo(y.minutes) with
            |   1 -> true
            |   _ -> false
