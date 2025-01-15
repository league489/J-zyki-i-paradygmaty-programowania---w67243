open System;
open System.Collections.Generic;


module LinkedList =
    
    type LinkedList<'T> =
        | Empty
        | Node of 'T * LinkedList<'T>

    let rec fromList = function
        | [] -> Empty
        | x :: xs -> Node(x, fromList xs)

    let rec printList list =
        match list with
        | Empty -> ()
        | Node(value, next) ->
            printf "%A " value
            printList next

    let head = function
        | Empty -> failwith "Nie można pobrać głowy z listy pustej"
        | Node(head, _) -> head

    let tail = function
        | Empty -> failwith "Nie można pobrać ogona z listy pustej"
        | Node(_, tail) -> tail

    let addHead(value, list) = Node(value, list)

    let rec numberElements = function
        | Empty -> 0
        | Node(_, tail) -> numberElements tail + 1

    let rec addAfter element newElement = function
        | Empty -> failwith ("Nie znaleziono elementu: " + element.ToString())
        | Node(head, tail) ->
            if head = element then
                Node(element, Node(newElement, tail))
            else
                Node(head, addAfter element newElement tail)

    let rec sumList = function
        | Empty -> 0
        | Node(head, tail) -> head + sumList tail

    let rec findMinMax list =
        match list with
        | Empty -> failwith "Lista jest pusta, brak elementów do porównania"
        | Node(value, tail) ->
            let rec helper currentMin currentMax remaining =
                match remaining with
                | Empty -> (currentMin, currentMax)
                | Node(v, t) ->
                    let newMin = min currentMin v
                    let newMax = max currentMax v
                    helper newMin newMax t
            helper value value tail

    let rec reverseList list =
        let rec helper list accumulator =
            match list with
            | Empty -> accumulator
            | Node(value, next) -> helper next (Node(value, accumulator))
        helper list Empty

    let rec contains element list =
        match list with
        | Empty -> false
        | Node(value, next) -> 
            if value = element then true
            else contains element next

    let rec countEntries lst sValue counter =
        match lst with
        | Empty -> counter
        | Node(value, next) ->
            let newCounter = 
                if value = sValue then counter + 1 else counter
            countEntries next sValue newCounter

    let rec findIndex element list currentIndex =
        match list with
        | Empty -> -1
        | Node(value, next) ->
            if value = element then currentIndex
            else findIndex element next (currentIndex + 1)

    let rec removeDuplicates list seen =
        match list with
        | Empty -> Empty
        | Node(value, next) ->
            if contains value seen then
                removeDuplicates next seen
            else
                Node(value, removeDuplicates next (Node(value, seen)))

    let rec filter filterFun list =
        match list with
        | Empty -> Empty
        | Node(value, next) ->
            if filterFun value then
                Node(value, filter filterFun next)
            else
                filter filterFun next

    let rec partition predicate list =
        match list with
        | Empty -> (Empty, Empty)
        | Node(value, next) ->
            let (matching, nonMatching) = partition predicate next
            if predicate value then
                (Node(value, matching), nonMatching)
            else
                (matching, Node(value, nonMatching))

    let rec mergeLists lst1 lst2 =
        match lst2 with
        | Empty -> lst1
        | Node(value, next) ->
            let newLst1 = Node(value, lst1)
            mergeLists newLst1 next
    
    let rec length lst =
        match lst with
        | Empty -> 0
        | Node(_, tail) -> 1 + length tail

    exception ListLengthMismatchException of string

    let rec compareLists lst1 lst2 =
        let len1 = length lst1
        let len2 = length lst2

        if len1 <> len2 then
            raise (ListLengthMismatchException("Listy mają różne długości"))
        else
            let rec helper l1 l2 =
                match (l1, l2) with
                | (Empty, Empty) -> []
                | (Node(v1, t1), Node(v2, t2)) -> (v1 > v2) :: helper t1 t2
                | _ -> failwith "Unexpected case"
            helper lst1 lst2


let rec readUserList() =
    printf("Podaj elementy listy oddzielone spacja; ");
    let input = Console.ReadLine();
    let items =
        input.Split(' ')
        |> Array.choose(fun x ->
            match Int32.TryParse(x) with
            | (true, v) -> Some v
            | _ -> None)
        |> Array.toList
    LinkedList.fromList items;



[<EntryPoint>]
let main argv= 
    let rec mainLoop () =
        printfn "Menu:"
        printfn "1. Wczytaj listę"
        printfn "2. Drukuj listę"
        printfn "3. Dodaj element na początek listy"
        printfn "4. Zlicz elementy w liście"
        printfn "5. Znajdź minimum i maksimum"
        printfn "6. Odwróć listę"
        printfn "7. Sprawdź, czy lista zawiera element"
        printfn "0. Wyjdź"
        let choice = Console.ReadLine()
        match choice with
        | "1" -> 
            readUserList()
            printfn "Lista wczytana."
            mainLoop()
        | "2" ->
            printfn "Podaj listę do wydrukowania:"
            let mutable list = readUserList()
            LinkedList.printList list
            printfn ""
            mainLoop()
        | "3" ->
            printfn "Podaj wartość do dodania na początek listy:"
            let value = int(Console.ReadLine())
            printfn "Podaj listę:"
            let mutable list = readUserList()
            let newList =  LinkedList.addHead(value, list)
            printfn "Nowa lista:"
            LinkedList.printList newList
            printfn ""
            mainLoop()
        | "4" ->
            printfn "Podaj listę do zliczenia elementów:"
            let mutable list = readUserList()
            let count =  LinkedList.numberElements list
            printfn "Liczba elementów w liście: %d" count
            mainLoop()
        | "5" ->
            printfn "Podaj listę do znalezienia minimum i maksimum:"
            let mutable list = readUserList()
            let (minValue, maxValue) =  LinkedList.findMinMax list
            printfn "Min: %d, Max: %d" minValue maxValue
            mainLoop()
        | "6" ->
            printfn "Podaj listę do odwrócenia:"
            let mutable list = readUserList()
            let reversedList =  LinkedList.reverseList list
            printfn "Odwrócona lista:"
            LinkedList.printList reversedList
            printfn ""
            mainLoop()
        | "7" ->
            printfn "Podaj wartość do sprawdzenia:"
            let value = int(Console.ReadLine())
            printfn "Podaj listę:"
            let mutable list = readUserList()
            let containsElement =  LinkedList.contains value list
            if containsElement then
                printfn "Lista zawiera element %d" value
            else
                printfn "Lista nie zawiera elementu %d" value
            mainLoop()
        | "0" ->
            printfn "Koniec programu."
            ()
        | _ ->
            printfn "Niepoprawna opcja, spróbuj ponownie."
            mainLoop()


 
    0;







