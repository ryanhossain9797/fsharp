let isPrime n =
    match n with
    | 1 -> false
    | _ when n > 3 && (n % 2 = 0 || n % 3 = 0) -> false
    | _ ->
        let maxDiv = int (System.Math.Sqrt(float n)) + 1

        let rec f d i =
            if d > maxDiv then true
            else if n % d = 0 then false
            else f (d + i) (6 - i)

        f 5 2

let nextPrime num =
    Seq.unfold (fun i -> Some(i, i + 1)) num
    |> Seq.find (isPrime)

let run num =
    Seq.unfold (fun i -> (nextPrime i) |> fun i -> Some(i, i + 1)) 1
    |> Seq.takeWhile (fun i -> i < num)
    |> Seq.map float
    |> Seq.sum

printfn "%f" (run 2000000)
