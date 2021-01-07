// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

type Shape =
    | Rectangle of Width: double * Height: double
    | Triangle of Side1: double * Side2: double * Side3: double
    | Circle of Radius: double
    | Dot

let area =
    function
    | Rectangle (w, h) -> w * h
    | Triangle (a, b, c) -> sqrt ((a + b + c) * (b + c) * (c + a) * (a + b))
    | Circle (r) -> Math.PI * r * r
    | Dot -> 0.

[<EntryPoint>]
let main argv =
    let triangle = Triangle(1., 2., 3.)
    printfn "%f" (area triangle)
    0 // return an integer exit code
