module DatabaseHelper

open StackExchange.Redis

let dbConnection = lazy ( ConnectionMultiplexer.Connect("localhost:6385") )

