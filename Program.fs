// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Geometry
open Creatures
open Basic
open Collections
open People

[<EntryPoint>]
let main argv =
    let triangle = Shape.Triangle(1., 2., 3.)
    printfn "%f" (Shape.area triangle)

    { Name = "Raiyan"; Age = 25 |> Age }
    |> incrementAge 3
    |> nameAndAge
    |> printfn "%s"

    let nums = [ 3 .. 2 .. 7 ]
    printfn "%O" nums

    addToList 1 nums |> printfn "%O"

    getFirstItem nums
    |> function
    | Some x -> printfn "%i" x
    | None -> printfn "fail"

    printEveryItem nums

    nums |> forEach (printfn "%O")

    0 // return an integer exit code
