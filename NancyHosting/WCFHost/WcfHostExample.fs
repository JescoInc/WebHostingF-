open System
open System.ServiceModel
open System.ServiceModel.Web
open Nancy.Hosting.Wcf

let host = new WebServiceHost(new NancyWcfGenericService(), new Uri("http://localhost:1234/base/"))
host.AddServiceEndpoint(typeof<NancyWcfGenericService>, new WebHttpBinding(), "")
host.Open()
printf "Now serving host : http://localhost:1234/base/ "
Console.ReadLine() |> ignore