// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let x = 
        let x = 5
        let y = 10
        x + y
    let printNumber number =
        printfn "%i" number
        
    printNumber x
    0 // return an integer exit code
    
// Result:
// 15
