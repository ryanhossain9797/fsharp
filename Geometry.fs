namespace Geometry

open System

module Shape =
    type Shape =
        | Rectangle of Width: double * Height: double
        | Triangle of Side1: double * Side2: double * Side3: double
        | Circle of Radius: double
        | Dot

    let area =
        function
        | Rectangle (w, h) -> w * h
        | Triangle (a, b, c) -> sqrt ((a + b + c) * (b + c) * (c + a) * (a + b))
        | Circle (r) -> Math.PI * r * r
        | Dot -> 0.
