module FP.Labs.Lab1

let rec pow (x: int) (n: int) =
    if n = 1 then x
    else x * pow (x) (n - 1)
    
let rec len (x: int) =
    if x / 10 < 1 then 1
    else 1 + len (x / 10)
    
let start () =
    printf "Введите степень тройки для которой нужно посчитать количество цифр\n"
    let degree = int (System.Console.ReadLine())
    let number = pow 3 degree
    printfn "3 в степени %d = %d, кол-во цифр = %d" (degree) (number) (len number)
    