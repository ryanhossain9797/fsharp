namespace ProblemThree

open System.Numerics

module ProblemThree =
    let target = 600851475143I

    let run =
        Seq.unfold
            (fun (num: BigInteger, div: BigInteger, maxFactor: BigInteger) ->
                if div > num then
                    None
                elif num % div = 0I then
                    Some((num, div, div), (num / div, div + 1I, div))
                else
                    Some((num, div, maxFactor), (num, div + 1I, maxFactor)))
            (target, 1I, 0I)
        |> Seq.maxBy (fun (_, _, maxFactor) -> maxFactor)
        |> fun (_, _, factor) -> factor
        |> printfn "%A"
