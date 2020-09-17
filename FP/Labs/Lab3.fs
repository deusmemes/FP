module FP.Labs.Lab3

let start (initialArray: array<int>) =
    let mutable A = initialArray
    let len = Array.length A
    let mutable prevElement = A.[0]

    for i = 1 to len - 2 do
        let mutable current = A.[i]
        A.[i] <- A.[i + 1] + prevElement
        prevElement <- current

    A |> Array.iter (fun el -> printf "%d " el)