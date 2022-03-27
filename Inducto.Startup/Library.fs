﻿module Inducto.Startup.Library

open System

let someList = [ 1; 2; 3; 4; 5 ]
let mapResult = someList |> Seq.map (fun x -> x * 2)
let filterResult = someList |> Seq.filter (fun x -> if x < 2 then failwith "Error" else x % 2 <> 0)
let iterResult = someList |> Seq.iter (fun x -> printf $"{x}")
let someResult = someList |> Seq.append [ 2; 3; 4; 5; 6 ]
someResult |> Seq.iter(fun x -> printfn $"Element: {x}")
let GetRandom() = Random().Next(10000, 99999).ToString()
let GetGuid() = Guid.NewGuid()
let someRandomStringList = [0..999] |> Seq.map(fun _ -> GetGuid())
someRandomStringList |> Seq.iter(fun x -> printfn $"String: {x}") 
