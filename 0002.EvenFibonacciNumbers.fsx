open System


let limit = 4000000

let run =
    Seq.unfold (fun (a, b) -> Some(b, (b, a + b))) (0l, 1l)
    |> Seq.takeWhile (fun num -> num <= limit)
    |> Seq.filter (fun num -> num % 2 = 0)
    |> Seq.sum

printfn "%i" run
