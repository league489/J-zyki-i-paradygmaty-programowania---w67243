open z1
open z2
open z3
open z4
open z5
open z6
[<EntryPoint>]
let main argv =
    let tekst_źródłowy = "Harry Potter i Komnata Tajemnic"
    printfn"Wprowadź słowo , którego szukasz w tekście: "
    let słowo = System.Console.ReadLine()
    PodmieńSłowo(tekst_źródłowy)(słowo)
    0

