module FP.Labs.Lab1

open System

let rec pow (x: bigint) (n: int) =
    if n = 1 then x
    else x * pow (x) (n - 1)
    
let rec len (x: bigint) =
    if x / 10I < 1I then 1
    else 1 + len (x / 10I)
    
let start () =
    printf "Введите степень тройки для которой нужно посчитать количество цифр\n"
    let degree = int (Console.ReadLine())
    let number = pow 3I degree
    printfn "3 в степени %d = %A, кол-во цифр = %d" (degree) (number) (len number)
    