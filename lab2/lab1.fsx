let mutable inputList = []

let parseText (text:string) = 
    if text.Length<=3 then text else text.Substring(0,3)

let sumUnits (unit:string) =    
      System.Int32.Parse(string unit[0])+System.Int32.Parse(string unit[1])+System.Int32.Parse(string unit[2])
      

let checkDevide(value:string) = 
    if (sumUnits value) = (sumUnits value) /3*3 then
        printfn "%s - divide 3" value
    else 
        printfn "%s - not divide 3" value
    if (sumUnits value) = (sumUnits value) /9*9 then
        printfn "%s - divide 9" value
    else 
        printfn "%s - not divide 9" value
       
    

let main argv = 
    printf "Input a: "
    inputList <-(parseText (string (System.Console.ReadLine())))::inputList
    printf "Input b: "
    inputList <-(parseText (string (System.Console.ReadLine())))::inputList
    
    checkDevide inputList[1]
    checkDevide inputList[0]
    
main()
