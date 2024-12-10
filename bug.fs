let mutable x = 10
let mutable y = 20

let add x y = 
    x <- x + y
    y

let result = add x y
printfn "%A" result //This will print 20 instead of 30 because of mutable variables
printfn "%A %A" x y //This will print 30 20 because of the mutation of x and y