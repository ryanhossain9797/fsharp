namespace Creatures

open System

type Age = Age of int

module People =

    type Person = { Name: String; Age: Age }

    let nameAndAge { Name = n; Age = Age a } = sprintf "%s %i" n a

    let incrementAge inc { Name = n; Age = Age a } = { Name = n; Age = (a + inc) |> Age }
