// Функциональный вариант
let rec makeMagicalNumberFunctional (n: bigint) =
    if n <= 0I then
        invalidArg "n" "Число должно быть положительным"
    elif n = 1I then
        [1I]
    elif n % 2I = 0I then
        n :: makeMagicalNumberFunctional (n / 2I)
    else
        n :: makeMagicalNumberFunctional (3I * n + 1I)

// Императивный вариант
let makeMagicalNumberImperative (n: bigint) =
    if n <= 0I then
        invalidArg "n" "Число должно быть положительным"
    let result = ResizeArray<bigint>()
    let mutable current = n
    while current > 1I do
        result.Add(current)
        if current % 2I = 0I then
            current <- current / 2I
        else
            current <- 3I * current + 1I
    result.Add(1I)
    List.ofSeq result

printfn "Функциональный вариант:"
for number in makeMagicalNumberFunctional 5I do
    printf "%O " number
printfn ""
printfn "Императивный вариант:"
for number in makeMagicalNumberImperative 5I do
    printf "%O " number
printfn ""
