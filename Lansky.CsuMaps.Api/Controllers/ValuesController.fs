namespace Lansky.CsuMaps.Api.Controllers

open Entities
open TownService
open Microsoft.AspNetCore.Mvc

[<Route("api")>]
type PopulationController () =
    inherit Controller()
    
    [<HttpGet("towns/{townId}/{year}")>]
    member this.GetById (townId : int32) (year : int32) : Town =
        getTownData year townId

    [<HttpGet("towns/{townName}/{year}")>]
    member this.GetByName (townName : string) (year : int32) : Town =
        townName |> getIdByName |> (getTownData year)