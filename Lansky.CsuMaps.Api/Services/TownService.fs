module TownService

open Entities
open DatabaseHelper

let getTownData (year : int32) (id : int32) : Town =
    let connection = dbConnection.Value
    let db = connection.GetDatabase()

    {
        Id = 0;
        Name = "";
        Year = 0;
        ``Start of the year population`` = 0;
        ``End of the year population`` = 0;
        Births = 0;
        Deaths = 0;
        Immigration = 0;
        Emigration = 0
    }

let getIdByName (name : string) : int32 =
    0