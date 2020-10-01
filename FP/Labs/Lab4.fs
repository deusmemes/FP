module FP.Labs.Lab4

open FP.Labs.SoftwareFirm

let start () =
    let junior = Junior("JuniorName")
    let senior = Senior("SeniorName")
    
    let app = SomeApp("Какое-то приложение")
    
    (junior :> IDeveloper).SayName()
    (senior :> IDeveloper).SayName()
    
    (junior :> IDeveloper).AddTask 4
    (senior :> IDeveloper).AddTask 5
    
    junior.StartWorkingDay()
    senior.StartWorkingDay()
    
    junior.StartDevelop app
    senior.StartDevelop app