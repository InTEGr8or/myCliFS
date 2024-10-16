// Learn more about F# at http://fsharp.org

namespace myCli

open System
open System.Text
open Argu

module Program =

    let thisWorld = Game.gameWorld
    
    let getLine = fun _ -> 
        printf "guess:>"
        let response = System.Console.ReadLine ()
        response.ToString()

    let writeResponse (s:string) =
        
        printf "Details: %s\n" s

    let rec progLoop () =
        let line = getLine()
        Game.par
        let result = Game.describeCurrentRoom(thisWorld)
        writeResponse(result.ToString())
        progLoop()

    [<EntryPoint>]
    let main argv =
        printf "A new world is online now %s." thisWorld.Player.Details.Name
        progLoop()

        0 // return an integer exit code
