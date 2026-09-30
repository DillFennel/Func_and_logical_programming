// Функциональный вариант
let rec makeCellsFunctional (numbers: int list) =
    match numbers with
    | [] -> []
    | number :: rest ->
        if number < 0 then
            invalidArg "numbers" "Числа должны быть неотрицательными"
        String.replicate number "#" :: makeCellsFunctional rest

// Императивный вариант
let makeCellsImperative (numbers: int list) =
    let result = ResizeArray<string>()
    for number in numbers do
        if number < 0 then
            invalidArg "numbers" "Числа должны быть неотрицательными"
        result.Add(String.replicate number "#")
    List.ofSeq result

// Ввод и вывод отделены от вычислений. Пустая строка завершает ввод
let inputNumbers = ResizeArray<int>()
let mutable reading = true
while reading do
    let value = System.Console.ReadLine()
    if System.String.IsNullOrEmpty(value) then
        reading <- false
    else
        inputNumbers.Add(System.Int32.Parse(value))

let numbers = List.ofSeq inputNumbers
let cellsFunctional = makeCellsFunctional numbers
let cellsImperative = makeCellsImperative numbers

printfn "Функциональный вариант:"
for cell in cellsFunctional do
    printfn "%s" cell
printfn "Императивный вариант:"
for cell in cellsImperative do
    printfn "%s" cell
