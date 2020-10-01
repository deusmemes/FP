module FP.Labs.SoftwareFirm

type IDeveloper =
    abstract member AddTask: int -> unit
    abstract member SayName: unit -> unit
    
type ISoftware =
    abstract member Develop: unit -> unit
   
type Junior(name: string) =
   interface IDeveloper with
      member this.SayName() = printfn "Я джуниор и меня зовут %s" name
      member this.AddTask hours = printfn "Я джуниор(%s), поэтому я сделаю это задание на %d часов" name (hours*2)
   
   abstract member StartWorkingDay: unit -> unit
   override this.StartWorkingDay() = printfn "Джуниор %s начал рабочий день" name
   
   abstract member StartDevelop: ISoftware -> unit
   override this.StartDevelop app =
      (app).Develop()
      printfn "Я джуниор, и поэтому немного накосячил"

   
type Senior(name: string) =
   inherit Junior(name)
   
   interface IDeveloper with
      member this.SayName() = printfn "Я сеньор и меня зовут %s" name
      member this.AddTask hours = printfn "Я сеньор(%s), поэтому я сделаю это задание на %d часов" name hours
      
   override this.StartWorkingDay() = printfn "Сеньор %s попил чай и начал рабочий день" name
   
   override this.StartDevelop app = (app).Develop()


type SomeApp(name: string) =
   interface ISoftware with
      member this.Develop() = printfn "Разработано приложение %s" name