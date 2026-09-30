// Функциональный вариант
let rec sumN n =
    if n <= 1I then n
    else n + sumN (n - 1I)

let rec sumNumbers (numbers: bigint list) =
    match numbers with
    | [] -> 0I
    | number :: rest -> number + sumNumbers rest

let checkNumbersFunctional (numbers: bigint list) =
    sumN (bigint (List.length numbers) + 1I) - sumNumbers numbers

// Императивный вариант
let checkNumbersImperative (numbers: bigint list) =
    let mutable fullSum = 0I
    for i in 1 .. (List.length numbers + 1) do
        fullSum <- fullSum + bigint i
    let mutable numbersSum = 0I
    for number in numbers do
        numbersSum <- numbersSum + number
    fullSum - numbersSum

printfn "Функциональный вариант:"
printfn "%O" (checkNumbersFunctional [1I; 2I; 3I; 5I])
printfn "Императивный вариант:"
printfn "%O" (checkNumbersImperative [1I; 2I; 3I; 5I])
