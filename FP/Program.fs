open FP.Labs

[<EntryPoint>]
let main argv =
    Lab1.start ()
    Lab2.start ()
    Lab3.start [| 4; 1; 5; 6; 2; 8; 0; 0; 1; 5 |]
    0
