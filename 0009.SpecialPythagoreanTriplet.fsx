let pythagorianTripleValidator num (n, m) =
    (n, m)
    |> fun (n, m) ->
        (((n ** 2.) - (m ** 2.))
         + (2. * n * m)
         + ((n ** 2.) + (m ** 2.))) = num

let run sum =
    [ 1 .. 32 ]
    |> Seq.map (fun a -> [ 1 .. a ] |> Seq.map (fun b -> (a, b)))
    |> Seq.concat
    |> Seq.map (fun (a, b) -> (float a, float b))
    |> Seq.find (pythagorianTripleValidator 1000.)
    |> fun (n, m) ->
        (((n ** 2.) - (m ** 2.))
         * (2. * n * m)
         * ((n ** 2.) + (m ** 2.)))

printfn "%A" (run 1000)
