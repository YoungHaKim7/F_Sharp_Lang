// For more information see https://aka.ms/fsharp-console-apps

open System

let printSomeText() =
    let text = "Hello" + "World"
    printfn $"text = {text}"

let showCommandLineArgs() =
    for arg in Environment.GetCommandLineArgs() do
        printfn $"arg = {arg}"

printSomeText()
showCommandLineArgs()
exit 100
  
