let add x y = 
    x + y

let x = 10
let y = 20

let result = add x y
printfn "%A" result //This will print 30 as expected
printfn "%A %A" x y //This will print 10 20 because x and y are not mutated