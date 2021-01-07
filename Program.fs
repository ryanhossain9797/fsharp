// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

[<EntryPoint>]
let main argv =
    let person = argv.[0]
    printfn "Hello %s" person
    0 // return an integer exit code
