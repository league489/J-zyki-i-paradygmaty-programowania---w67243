module File1

//type Person(name: string, age: int) =
// // Pole
// let mutable _name = name
// let mutable _age = age
// // Właściwości
// member this.Name
//    with get() = _name
//    and set(value) = _name <- value
// member this.Age
//     with get() = _age
//     and set(value) = _age <- value
// // Metoda
// member this.Introduce() =
//    printfn "Cześć, jestem %s i mam %d lat." _name _age

//type Pracownik(name: string, age: int, position:string) =
//    inherit Person(name,age)

//    member this.Position = position

//type IWalkable = abstract member Walk: unit -> unit

//type Person(name:string) =
//   member val Name = name with get,set
   
//    interface IWalkable with
//        member

type Animal  = member this.Speak() = printf "Zwierze wydaje głos"

type Dog = 
    inherit Animal
    override this.Speak() = printf "Pies szczeka"