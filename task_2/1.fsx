// Функциональный вариант
let rec reverseStringFunctional (s: string) =
    if s.Length = 0 then
        ""
    else
        string s.[s.Length - 1] + reverseStringFunctional (s.Substring(0, s.Length - 1))

// Императивный вариант
let reverseStringImperative (s: string) =
    let mutable result = ""
    for character in s do
        result <- string character + result
    result

printfn "Функциональный вариант:"
printfn "%s" (reverseStringFunctional "hello!")
printfn "Императивный вариант:"
printfn "%s" (reverseStringImperative "hello!")
