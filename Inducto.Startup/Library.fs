module Inducto.Startup.Library

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
let maper = someList|> List.map ( fun x -> x+1)
let odd x = x%2=0
let filtrer = someList|> List.filter odd 
let plus x y = x+y
let plusone = plus 1
let itog = plusone 1

let som1 = someList |> List.map plusone

type Input = Input of string

open System
let input = ["a"; "3"; "f"; "55"]


let toint1 = 
    input 
    |> List.map Int32.TryParse
    |> List.filter (fun (x,y) -> x )
    |> List.map snd
    |> List.map (fun x -> x.ToString())


