// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
open System.IO

let sayHellow = printfn "Hellow %s"

[<EntryPoint>]
let main argv =
    if argv.Length > 0 then
        if File.Exists argv.[0] then
            let studentCount =
                File.ReadAllLines argv.[0]
                |> Array.toList
                |> List.tail
                |> List.length
                |> printfn "%i"

            0
        else
            printfn "File does not exist"
            2
    else
        printfn "Please specify file name"
        1
