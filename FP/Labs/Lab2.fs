module FP.Labs.Lab2

open System
open System.IO

let start () =
    let write (path: string) (input: string) = File.WriteAllText(path, input)

    let read path = File.ReadLines path
                    |> Seq.map(fun (line: string) -> line.Split(' '))
                    |> Seq.concat

    let text = read(@"lab2.txt")

    let rec reverse (str: string) = str |> Seq.rev |> String.Concat

    let result = text
                |> Seq.mapi (fun (i: int) (el: string) -> if i % 2 <> 0 then (reverse el) else el)
                |> String.concat " "

    write @"out.txt" result