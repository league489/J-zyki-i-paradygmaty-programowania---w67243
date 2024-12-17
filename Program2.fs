module Program2





//// Funkcja dodająca element na początek listy
//let addHead value list =
// Node(value, list)
//// Funkcja wyświetlająca elementy listy
//let rec printList list =
// match list with
// | Empty -> ()
// | Node(value, next) ->
// printf "%A " value
// printList next
//// Funkcja rekurencyjna obliczająca ilość elementów na liście
//let rec numberElements =
// function
// | Empty -> 0
// | Node (_,Tail) -> numberElements Tail + 1
//// Funckja wyszukująca element na liście, i dodające nowy element za nią
//// element - poszukiwany element listy
//// newElement - nowy element, który chcemy wstawić
//let rec addAfter element newElement =
// function
// | Empty -> failwith ("Nie znaleziono elementu: " + element.ToString())
// | Node (Head,Tail) ->
// if Head = element then
// Node(element, Node (newElement, Tail))
// else
// Node(Head, addAfter element newElement Tail)
//// Przykład użycia
//[<EntryPoint>]
//let main argv =

// let list1 = Empty
// let list2 = addHead 1 list1
// let list3 = addHead 2 list2
// let list4 = addHead 3 list3
// let ilosc = numberElements list4
// printList list4 // Wynik: 3 2 1
// printf "%d" ilosc
// 0


////lista na podstawie listy od użytkownika
//let rec fromList =
//    function
//    |[] ->Empty
//    |x::xs -> Node(x,fromlist xs)

//let rec readUserList =
//    printfn "Podaj elementy listy oddzielone spacją: "
//    let input = Console.ReadLine()
//    let items =
//        input.split(" ")
//        |> Array.choose(fun x -> 
//            match Int32.TryParse(x) with
//            |(true,v) -> Some v
//            |_ -> None)
//        |> Array.toList
//    LinkedList.fromList items

//let rec sumlist =
//    function
//    |empty -> 0
//    |node(x,xs) -> x + sumlist xs

let rec findMax list =
    match list with
    |Empty -> failwith "Lista jest pusta , nie ma porównania"
    |Node(Value,Tail) -> 
        let rec helper currentMin currentMax remaining =
            match remaining with
            |Empty -> (currentMin,currentMax)
            |Node(v,t) ->
                let newMin = min currentMin v
                let newMax = max currentMax v
                helper newMin newMax t
        helper Value Value Tail