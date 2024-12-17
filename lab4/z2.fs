module z2

//let DolarKurs = Map.ofList(["PLN",4.06; "GBP",0.78;"EUR",0.94])
//let EuroKurs = Map.ofList(["PLN",4.34; "GBP",0.83;"USD",1.07])
//let FuntKurs = Map.ofList(["PLN",5.24; "USD",1.29;"EUR",1.21])
//let ZłotyKurs = Map.ofList(["GBP",0.19; "USD",0.25;"EUR",0.23])



//let podajKurs (WalutaZ: string) (WalutaD: string) =
//    if WalutaZ = "USD" then
//        match DolarKurs.TryFind WalutaD with
//        | Some kursFinalny -> kursFinalny
//        | None -> 
//            printfn "Nie znaleziono kursu wymiany dla waluty docelowej: %s" WalutaD
//            0.0 
//    elif WalutaZ = "EUR" then
//        match EuroKurs.TryFind WalutaD with
//        |Some kursFinalny -> kursFinalny 
//        |None -> 
//             printfn "Nie znaleziono kursu wymiany dla waluty docelowej: %s" WalutaD
//             0.0
//    elif WalutaZ = "PLN" then
//        match ZłotyKurs.TryFind WalutaD with
//        |Some kursFinalny -> kursFinalny 
//        |None -> 
//             printfn "Nie znaleziono kursu wymiany dla waluty docelowej: %s" WalutaD
//             0.0
//    elif WalutaZ = "GBP" then
//        match FuntKurs.TryFind WalutaD with
//        |Some kursFinalny -> kursFinalny 
//        |None -> 
//             printfn "Nie znaleziono kursu wymiany dla waluty docelowej: %s" WalutaD
//             0.0
//    else
//     printfn "Waluta niedostępna."
//     0.0 
//printfn "Podaj walutę, którą chcesz wymienić: "
//let inputSourceCurrency = System.Console.ReadLine()
//printf "Podaj ilość waluty: "
//let CurrencyAmount = System.Console.ReadLine()
//let floatCurrencyAmount = float CurrencyAmount
//printfn "Podaj walutę docelową: "
//let finalCurrency = System.Console.ReadLine()
//let mutable wymiana = floatCurrencyAmount * podajKurs inputSourceCurrency finalCurrency
//printfn $"Po wymianie  %F{floatCurrencyAmount} %s{inputSourceCurrency} na %s{finalCurrency} otrzymujesz %F{wymiana} %s{finalCurrency} "



