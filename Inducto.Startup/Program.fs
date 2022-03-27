module Inducto.Library.Main

open System

type Gender =
    | Male
    | Female

let Names =
    [ "James"
      "Robert"
      "John"
      "Michael"
      "William"
      "David"
      "Richard"
      "Joseph"
      "Thomas"
      "Charles"
      "Christopher"
      "Daniel"
      "Matthew"
      "Anthony"
      "Jeffrey"
      "Ryan"
      "Jacob"
      "Gary"
      "Nicholas"
      "Eric"
      "Jonathan"
      "Stephen"
      "Larry"
      "Justin"
      "Scott"
      "Brandon"
      "Samuel"
      "Gregory"
      "Frank"
      "Alexander"
      "Raymond"
      "Patrick"
      "Jack"
      "Dennis"
      "Jerry"
      "Tyler"
      "Aaron"
      "Jose"
      "Adam"
      "Henry"
      "Nathan"
      "Douglas"
      "Zachary"
      "Peter"
      "Kyle"
      "Walter"
      "Ethan"
      "Jeremy"
      "Harold"
      "Keith"
      "Christian"
      "Roger"
      "Noah"
      "Gerald"
      "Carl"
      "Terry"
      "Sean"
      "Austin"
      "Arthur"
      "Lawrence"
      "Jesse"
      "Dylan"
      "Bryan"
      "Joe"
      "Jordan"
      "Billy"
      "Bruce"
      "Albert"
      "Willie"
      "Gabriel"
      "Logan"
      "Alan"
      "Juan"
      "Wayne"
      "Roy"
      "Ralph"
      "Randy"
      "Eugene"
      "Vincent"
      "Russell"
      "Elijah"
      "Louis"
      "Bobby"
      "Philip"
      "Johnny" ]
let GetRandom x y = Random().Next(x, y)
let GetRandomName () = Names |> List.item (GetRandom 0 (Names.Length - 1))
let GetRandomAge () = GetRandom 18 60
let GetRandomSalary () = float <| GetRandom 10000 45000 
let GetRandomGender () = if GetRandom 0 100 < 50 then Female else Male

type Employee(id, name, age, salary, gender) =
    member x.Id = id
    member x.Name = name
    member x.Age = age
    member x.Salary = salary
    member x.Gender = gender
    override x.ToString() = $"{x.Name} {x.Age} {x.Salary} {x.Gender}"
    member x.Redundant sal = if sal > 5000.0 then printfn "good boy" else printfn "u fired"

type Driver(id, name, age, salary, gender) =
    inherit Employee(id, name, age, salary, gender)
    member x.LicenceNumber = 0

let Employees = [ for n in 0 .. 1000 -> Employee(n, GetRandomName(), GetRandomAge(), GetRandomSalary(), GetRandomGender()) ]

printfn "\nPERSONS:\n"
Employees |> Seq.iter(fun employee -> printfn $"{employee}" )


