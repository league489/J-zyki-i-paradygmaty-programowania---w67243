module z1
//let ZliczSłowa (text: string) =
//    let słowa = text.Split([|' '; '.'; ','; '\n'|], System.StringSplitOptions.RemoveEmptyEntries) |> Array.length
//    printfn $"Liczba słów: {słowa}"


//let ZliczZnaki (tekst:string) = 

//    let znaki = List.ofArray(tekst.Split([|' '; '.'; ','; '\n'|], System.StringSplitOptions.RemoveEmptyEntries)) |> List.map(fun x -> x.Length) |> List.reduce(fun x y -> x+y)
//    printfn $"Liczba znaków: {znaki}"


//printfn"Wprowadź tekst do analizy"
//let TekstDoAnallzy = System.Console.ReadLine()
//ZliczSłowa(TekstDoAnallzy)
//ZliczZnaki(TekstDoAnallzy)