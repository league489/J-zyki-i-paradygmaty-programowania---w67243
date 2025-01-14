module z5
//let ZliczanieSłów (text:string) =
//    let words = text.Split [|' '|]
//    let wordlist = Array.toList words
//    let zliczenie = wordlist |> List.countBy id
//    printf $"Zliczone wystąpienia słów:\n"
//    for w in zliczenie do
//        printfn $"{w}"
    

//let readFile (filePath: string) =
//    try
//        let content = File.ReadAllText(filePath)
//        printfn "Plik został odczytany pomyślnie."
//        content
//    with
//    | :? FileNotFoundException -> 
//        printfn "Plik nie został znaleziony."
//        ""
//    | :? UnauthorizedAccessException -> 
//        printfn "Brak uprawnień do odczytu pliku."
//        ""
//    | ex -> 
//        printfn "Inny błąd: %s" ex.Message
//        ""   

//let ZliczSłowaWPliku(plik:string) =
//    let OdczytajPlik = readFile plik
//    let ZliczoneSłowa = ZliczanieSłów OdczytajPlik
//    printfn " "

//    ZliczSłowaWPliku "C:\Users\leagu\OneDrive\Pulpit\Laboratorium\lab9\Plik.txt"