module Inducto.Library.Main

open Inducto.Startup.Reflection


// Hello from my home

type Gender =
    | Binary
    | NonBinary

type Employee(name, age, salary, gender) =
    member x.Name = name
    member x.Age = age
    member x.Salary = salary
    member x.Gender = GetCaseByName<Gender> gender
    override x.ToString() = $"{x.Name} {x.Age} {x.Salary} {x.Gender}"
    member x.Redundant sal =
        if sal > 5000.0
        then printfn "good boy"
        else printfn "u fired"

type Driver(name, age, salary, gender) =
    inherit Employee(name, age, salary, gender)
    member x.LicenceNumber = 0

let hobo = Employee("Bob", 45, 1500.0, "NonBinary")
let hoboDriver = Driver(hobo.Name,hobo.Age, hobo.Salary, hobo.Gender.ToString())
let hoboEmployee = hoboDriver :> Employee
let employeeList = [ hobo; hoboEmployee ]
employeeList|> Seq.iter (fun x -> printf $"{x.Name}" )

