namespace ProblemFive

module ProblemFive =
    let nums = [ 1 .. 20 ]

    let rec highestCommonFactor a b =
        match (a, b) with
        | (0, b) -> b
        | (a, b) -> highestCommonFactor (b % a) a

    let leastCommonMultiple a b = (b / (highestCommonFactor b a)) * a

    let run =
        nums
        |> List.fold (leastCommonMultiple) 1
        |> printfn "%i"
