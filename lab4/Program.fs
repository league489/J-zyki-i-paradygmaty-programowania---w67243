open z1
open z2
open z3
open z4
open z5
open System
//    else 
//         "y jest większy"
        
//let listaA = [1;2;3;4]
//let listaB = 0:: listaA

////for item in listaA do
////    printf "%d " item

//let listaC = listaA @ listaB

//for item in listaC do
//    printf "%d " item

//type Osoba ={
//    Imie: string;
//    Wiek: int;  }
//let sosba1 = {Imie = "Jan"; Wiek = 12}
//let osoba2 = {Imie = "Janina"; Wiek = 30}
//let krotka = (1, "ala", true)






// Rozpoczęcie gry
[<EntryPoint>]
let main argv =
    printfn "Gra Kółko i Krzyżyk"
    graj ()
    0

