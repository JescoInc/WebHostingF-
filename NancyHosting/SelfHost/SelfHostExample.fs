open System
open Nancy.Hosting.Self

let host = new NancyHost(new Uri("http://localhost:1234"))

printf "Running on http://localhost:1234"
host.Start()
Console.ReadLine() |> ignore