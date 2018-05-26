module TownProcessor

open Okresy
open DatabaseHelper
open FSharp.ExcelProvider
open System.Net
open Entities

type TownExcel = ExcelFile<"cz0521.xlsx">

let inline (!>) (x:^a) : ^b = ((^a or ^b) : (static member op_Implicit : ^a -> ^b) x) 

let getUrl (id : OkresId) : string =
    sprintf "https://www.czso.cz/staticke/cz/obce_d/pohyb/cz%s.xlsx" (value id)

let getCachedDocument (url : string) : byte array option =
    let db = dbConnection.Value.GetDatabase()
    let cachedValue = db.StringGet(!> url)

    Some (!> cachedValue)

let setCachedDocument (url : string) (doc : byte array) =
    let db = dbConnection.Value.GetDatabase()
    db.StringSet(!> url, !> doc) |> ignore

let downloadDocument (url : string) : byte array =
    WebClient().DownloadData(url)

let downloadWithCaching (url : string) : byte array =
    printfn "Downloading %s" url

    match getCachedDocument url with
        | Some doc -> doc
        | None ->
            let downloadedDoc = downloadDocument url
            setCachedDocument url downloadedDoc
            downloadedDoc

let loadDoc (doc : byte array) : Town array =
    let tempFile = System.IO.Path.GetTempFileName()
    System.IO.File.WriteAllBytes(tempFile, doc)
    let rows = TownExcel(tempFile).Data
    rows |> Seq.map (fun row -> {
                                    Id = (int row.``Číslo\nobce``);
                                    Name = row.``Název obce``;
                                    Year = (int row.Rok);
                                    ``Start of the year population`` = (int row.``Stav 1.1.``);
                                    ``End of the year population`` = (int row.``Stav 31.12.``);
                                    Births = (int row.Narození);
                                    Deaths = (int row.Zemřelí);
                                    Immigration = (int row.``Přistě-\nhovalí``);
                                    Emigration = (int row.``Vystě-\nhovalí``)
                                }) |> Array.ofSeq

let importTownData() =
    let urls = okresList
                |> Array.map (fun okres -> okres.id)
                |> Array.map getUrl
                |> Array.map downloadWithCaching
                |> Array.map loadDoc

    ()