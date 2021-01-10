namespace Basic

module Math =
    let add x y = x + y

module Collections =
    let addToList x xs = x :: xs

    let getFirstItem =
        function
        | x :: _ -> Some x
        | _ -> None

    let rec forEach f =
        function
        | x :: xs ->
            f x
            xs |> forEach f
        | [] -> ()

    let printEveryItem list = forEach (printf "%O ") list
