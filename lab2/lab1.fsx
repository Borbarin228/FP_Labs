
let area a b c =
    let s = (fun a b c ->(a + b + c) / 2.0)a b c
    sqrt ((fun a b c s -> s * (s - a) * (s - b) * (s - c))a b c s)

let mutable list = []

let main argv =
    
    printf "Input a: "
    list <-(float (System.Console.ReadLine()))::list

    printf "Input b: "
    list <-(float (System.Console.ReadLine()))::list

    printf "Input c: "
    list <-(float (System.Console.ReadLine()))::list

    
    printfn "Perimeter: %f" ((fun a b c -> a + b + c)list[0] list[1] list[2])
    printfn "Area: %f" (area list[0] list[1] list[2])

main()