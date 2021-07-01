// Note this one has runtime errors on HackerRank

open System

let run (n: uint64) =
    [ 1UL .. (n - 1UL) ]
    |> List.filter (fun x -> x % 3UL = 0UL || x % 5UL = 0UL)
    |> List.sum


{ 1UL .. (Console.ReadLine() |> uint64) }
|> Seq.map (fun _ -> (Console.ReadLine() |> uint64))
|> Seq.map run
|> Seq.iter (printfn "%i")
