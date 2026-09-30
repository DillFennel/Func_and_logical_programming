// Функциональный вариант
let checkNumbersFunctional (numbers: int list) =
    let rec loop remaining maxLength maxValue currentLength =
        match remaining with
        | [] -> 0
        | [number] ->
            if maxLength >= currentLength then maxValue
            else number
        | first :: (second :: _ as rest) ->
            if first = second then
                loop rest maxLength maxValue (currentLength + 1)
            elif maxLength >= currentLength then
                loop rest maxLength maxValue 1
            else
                loop rest currentLength first 1
    loop numbers 0 0 1

// Императивный вариант
let checkNumbersImperative (numbers: int list) =
    let values = List.toArray numbers
    if values.Length = 0 then
        0
    else
        let mutable maxLength = 0
        let mutable maxValue = 0
        let mutable currentLength = 1
        for i in 1 .. (values.Length - 1) do
            if values.[i] = values.[i - 1] then
                currentLength <- currentLength + 1
            else
                if maxLength < currentLength then
                    maxLength <- currentLength
                    maxValue <- values.[i - 1]
                currentLength <- 1
        if maxLength < currentLength then
            maxValue <- values.[values.Length - 1]
        maxValue

let examples =
    [ [1; 2; 3; 4; 5] // 1
      [1; 2; 3; 4; 5; 5] // 5
      [1; 2; 3; 3; 3; 4; 5; 5] // 3
      [1; 1; 1; 1; 2; 3; 5; 5; 5; 5] ] // 1

printfn "Функциональный вариант:"
for numbers in examples do
    printfn "%d" (checkNumbersFunctional numbers)
printfn "Императивный вариант:"
for numbers in examples do
    printfn "%d" (checkNumbersImperative numbers)
