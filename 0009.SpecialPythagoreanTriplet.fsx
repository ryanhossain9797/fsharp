let run =
    1
    |> Seq.unfold (fun n -> Some(n, n + 1))
    |> Seq.take (1000 / 3 + 2)
    |> Seq.map (fun n -> (n, n + 1, n + 2))
    |> Seq.find (fun (a, b, c) -> (a * a + b * b = c * c) && (a + b + c = 1000))
    |> (fun (a, b, c) -> (a * b * c))

printfn "%i" run
