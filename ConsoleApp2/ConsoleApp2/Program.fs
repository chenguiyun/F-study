// Learn more about F# at http://fsharp.org

open System

let re x y:int=(x*y);


let test() =
   for i = 1 to 9 do
      for j = 1 to 9 do
         printfn "%d * %d = %d"i j (re i j)
[<EntryPoint>]
let main argv =
    test()
    0 // return an integer exit code
