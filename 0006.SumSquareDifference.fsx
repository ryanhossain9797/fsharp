let run =
    [ 1 .. 100 ]
    |> List.fold (fun (squareSum, sum) num -> (squareSum + (num * num), sum + num)) (0, 0)
    |> fun (squareSum, sum) -> (sum * sum) - squareSum

printfn "%i" run
