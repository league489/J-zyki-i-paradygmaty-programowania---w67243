module z4
//open System
//open System.Collections.Generic

//type Konto = {
//    NrKonta:int
//    Właściciel:string
//    StanKonta: float
//}


//let mutable Konta = Map.empty<int,Konto>


//let UtwórzKonto()=
// printfn("Podaj numer konta: ")
// let nr_konta = System.Console.ReadLine() |> int
// printfn("Wprowadź dane właściciela konta: ")
// let właściciel = System.Console.ReadLine()
// let saldo = 100.0
// if Konta.ContainsKey(nr_konta) then
//    let noweKonto = {NrKonta=0;Właściciel ="";StanKonta=0}
//    printfn "Konto o tym numerze już istnieje"
    
// else
//   let noweKonto = {NrKonta=nr_konta;Właściciel = właściciel;StanKonta=saldo}
//   Konta <- Konta.Add(nr_konta, noweKonto)
//   printfn "Utworzono konto dla:%s" właściciel
   
 

//let SprawdźSaldo (nrKonta:int) =
//    let klient = Konta.[nrKonta]
//    printfn $"Stan konta dla {klient.Właściciel}: {klient.StanKonta}"
    



//let Wpłata (nrKonta:int) (wpłata: float) =
//    if Konta.ContainsKey(nrKonta) then
//        let stareKonto = Konta.[nrKonta]
//        let noweSaldo = stareKonto.StanKonta + wpłata
//        let noweKonto = { stareKonto with StanKonta = noweSaldo }
//        Konta <- Konta.Add(nrKonta, noweKonto)
//        printfn $"Zaktualizowano stan konta {nrKonta}. Nowy stan konta: {noweSaldo}"
//    else
//        printfn "Nie ma takiego konta"


//let Wypłata (nrKonta) (wypłata: float) =
//    if Konta.ContainsKey(nrKonta) then
//        if Konta.[nrKonta].StanKonta < wypłata then
//             printfn $"Brak wystarczających środków na koncie"
//        else
//        let stareKonto = Konta.[nrKonta]
//        let noweSaldo = stareKonto.StanKonta - wypłata
//        let noweKonto = { stareKonto with StanKonta = noweSaldo }
//        Konta <- Konta.Add(nrKonta, noweKonto)
//        printfn $"Zaktualizowano stan konta {nrKonta}. Nowy stan konta: {noweSaldo}"



//    else
//        printfn "Nie ma takiego konta"







//     printfn "Aplikacja bankowa"
//    let mutable opcja = 0
//    while opcja <> 10 do
//        printfn "Menu: \n1. Utwórz Konto \n2. Sprawdź Saldo \n3. Wpłata \n4. Wypłata \n5. Wyjście"
//        opcja <- Console.ReadLine() |> int
//        match opcja with
//        | 1 -> UtwórzKonto()
//        | 2 -> 
//            printfn "Wprowadź numer konta: "
//            let nr_konta = Console.ReadLine() |> int
//            SprawdźSaldo nr_konta
//        | 3 -> 
//            printfn "Wprowadź numer konta: "
//            let nr_konta = Console.ReadLine() |> int
//            printfn "Wprowadź kwotę wpłaty: "
//            let kwota = Console.ReadLine() |> float
//            Wpłata nr_konta kwota
//        | 4 -> 
//            printfn "Wprowadź numer konta: "
//            let nr_konta = Console.ReadLine() |> int
//            printfn "Wprowadź kwotę wypłaty: "
//            let kwota = Console.ReadLine() |> float
//            Wypłata nr_konta kwota
//        | 5 -> printfn "Do widzenia!"
//        | _ -> printfn "Nieprawidłowa opcja, spróbuj ponownie."




