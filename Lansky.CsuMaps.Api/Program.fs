namespace Lansky.CsuMaps.Api

open Microsoft.AspNetCore
open Microsoft.AspNetCore.Hosting

open TownProcessor

module Program =
    let exitCode = 0

    let BuildWebHost args =
        WebHost
            .CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build()

    [<EntryPoint>]
    let main args =
        importTownData()
        BuildWebHost(args).Run()

        exitCode
