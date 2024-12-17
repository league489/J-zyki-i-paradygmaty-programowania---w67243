module z5
//open System
//open System.Collections.Generic

////let kombinacje =  [[[0;0;1];[0;0;1];[0;0;1]];[[0;1;0];[0;1;0];[0;1;0]]]
////let KółkoIKrzyżyk(plansza) = 
////    if List.contains(plansza) kombinacje then 
////        printfn "Wygrał gracz"
//let porownajMacierze m1 m2 =
//    if List.length m1 <> List.length m2 then
//        false
//    else
//        List.forall2 (fun row1 row2 -> List.forall2 (=) row1 row2) m1 m2

//let kombinacje_gracz =  
//    [
//     [["O";"X";"O"];["O";"X";"O"];["O";"X";"O"]];
//     [["X";"O";"O"];["X";"O";"O"];["X";"O";"O"]];
//     [["X";"O";"O"]]
//    ]

//let KółkoIKrzyżyk plansza = 
//    if List.exists (fun k -> porownajMacierze k plansza) kombinacje_gracz then 
//        printfn "Wygrał gracz"
//    else
//        printfn "Gra toczy się dalej"
open System

// Reprezentacja planszy
let mutable plansza = Array2D.create 3 3 ' '

// Wyświetlanie planszy
let wyswietlPlansze () =
    for i in 0 .. 2 do
        for j in 0 .. 2 do
            printf "%c " plansza.[i, j]
        printfn ""

// Wybór pozycji przez gracza
let rec ruchGracza () =
    printfn "Wprowadź numer wiersza (0, 1, 2): "
    let wiersz = Console.ReadLine() |> int
    printfn "Wprowadź numer kolumny (0, 1, 2): "
    let kolumna = Console.ReadLine() |> int
    if plansza.[wiersz, kolumna] = ' ' then
        plansza.[wiersz, kolumna] <- 'X'
    else
        printfn "Pole już zajęte, spróbuj ponownie."
        ruchGracza ()

// Ruch komputera
let ruchKomputera () =
    let rand = Random()
    let mutable wykonanoRuch = false
    while not wykonanoRuch do
        let wiersz = rand.Next(0, 3)
        let kolumna = rand.Next(0, 3)
        if plansza.[wiersz, kolumna] = ' ' then
            plansza.[wiersz, kolumna] <- 'O'
            wykonanoRuch <- true

// Sprawdzanie wygranej
let sprawdzWygrana gracz =
    let wygranaWiersze = Array.exists (fun i -> Array.forall (fun j -> plansza.[i, j] = gracz) [|0; 1; 2|]) [|0; 1; 2|]
    let wygranaKolumny = Array.exists (fun j -> Array.forall (fun i -> plansza.[i, j] = gracz) [|0; 1; 2|]) [|0; 1; 2|]
    let wygranaSkos1 = Array.forall (fun i -> plansza.[i, i] = gracz) [|0; 1; 2|]
    let wygranaSkos2 = Array.forall (fun i -> plansza.[i, 2 - i] = gracz) [|0; 1; 2|]
    wygranaWiersze || wygranaKolumny || wygranaSkos1 || wygranaSkos2

// Sprawdzanie remisu
let sprawdzRemis () =
    not (Array.exists (fun i -> Array.exists (fun j -> plansza.[i, j] = ' ') [|0; 1; 2|]) [|0; 1; 2|])

// Pętla główna gry
let rec graj () =
    wyswietlPlansze ()
    printfn "Ruch gracza:"
    ruchGracza ()
    if sprawdzWygrana 'X' then
        wyswietlPlansze ()
        printfn "Gracz wygrywa!"
    elif sprawdzRemis () then
        wyswietlPlansze ()
        printfn "Remis!"
    else
        printfn "Ruch komputera:"
        ruchKomputera ()
        if sprawdzWygrana 'O' then
            wyswietlPlansze ()
            printfn "Komputer wygrywa!"
        elif sprawdzRemis () then
            wyswietlPlansze ()
            printfn "Remis!"
        else
            graj ()





