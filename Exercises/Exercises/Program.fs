[<EntryPoint>]
let main argv = 
    let mutable sum = 0
    for i in [0..100] do
        if i % 2 <> 0 then sum <- sum + i
    printf "the sum of odd numbers from 0 to 100 is %d \n" sum
    0