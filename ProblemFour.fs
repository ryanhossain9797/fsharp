namespace ProblemFour

module ProblemFour =
    let threeDigits = [ 100 .. 999 ]

    let isPalindrome num =
        num
        |> (fun num ->
            num.ToString()
            |> fun num -> (num.[..(num.Length / 2)], num.[(num.Length - ((num.Length / 2) + 1))..]))
        |> (fun (a, b) ->
            a = (b.ToCharArray()
                 |> Array.toSeq
                 |> Seq.rev
                 |> System.String.Concat))


    let run =
        List.collect (fun m -> (threeDigits |> List.map (fun n -> m * n))) threeDigits
        |> List.filter isPalindrome
        |> List.max
        |> printfn "%i"
