module Program23

//23.4.1. В фэнтези-РПГ принята следующая денежная система: в одном золотом 20 серебряных, 
//а в одном серебряном 12 медяков. Суммы в такой системе задаются тройками целых чисел (золотые, серебряные, медяки),
//например (1, 0, 128) или (32, 23, 5)
let (.+.) x y = 
    let (gold1, silver1, copper1) = x
    let (gold2, silver2, copper2) = y
    let allCoppers1 = gold1 * 20 * 12 + silver1 * 12 + copper1
    let allCoppers2 = gold2 * 20 * 12 + silver2 * 12 + copper2
    let allCoppers = allCoppers1 + allCoppers2
    let resultGold = allCoppers / (20 * 12)
    let resultSilver = (allCoppers % (20 * 12)) / 12
    let resultCoppers = (allCoppers % (20 * 12)) % 12
    (resultGold, resultSilver, resultCoppers)

let (.-.) x y = 
    let (a, b) = if x < y then (y, x) else (x, y)
   
    let (gold1, silver1, copper1) = a
    let (gold2, silver2, copper2) = b
    let allCoppers1 = gold1 * 20 * 12 + silver1 * 12 + copper1
    let allCoppers2 = gold2 * 20 * 12 + silver2 * 12 + copper2
    let allCoppers = allCoppers1 - allCoppers2
    let resultGold = allCoppers / (20 * 12)
    let resultSilver = (allCoppers % (20 * 12)) / 12
    let resultCoppers = (allCoppers % (20 * 12)) % 12
    if a = x then (resultGold, resultSilver, resultCoppers) else (- resultGold, - resultSilver, - resultCoppers)


//23.4.2. Реализуйте логику работы с комплексными числами. Комплексное число задаётся парой вещественных чисел (x,y)
let (.+) x y =
    let (a, b) = x
    let (c, d) = y
    (a + c, b + d)

let (.-) x y =
    let (a, b) = x
    let (c, d) = y
    (a - c, b - d)

let (.*) x y = 
    let (a, b) = x
    let (c, d) = y
    (a * c - b * d, b * c + a * d)

let (./) x y = 
    let (a, b) = x
    let (c, d) = y
    (a/(a * a + b * b), -b / (a * a + b * b))