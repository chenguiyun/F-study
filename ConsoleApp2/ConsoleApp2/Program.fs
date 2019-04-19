// Learn more about F# at http://fsharp.org

open System

let re x y:int=(x*y);


let test() =
   for i = 1 to 9 do
      for j = 1 to 9 do
         printfn "%d * %d = %d"i j (re i j)
let a=50000000.0
let b=99999999999.00000001
let c=a * b;
let ca()=printfn "%f" c

[<EntryPoint>]
let main argv =
    //test()
    ca()
    0 // return an integer exit code
