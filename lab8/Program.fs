open System;
open System.Collections.Generic;


type LinkedList<'T> =
    | Empty
    | Node of 'T * LinkedList<'T>



module LinkedList =
    
    let rec fromList =
        function
        | [] -> Empty;
        | x :: xs -> Node(x, fromList xs)


    let rec printList(list) =
        match list with
        | Empty -> ()
        | Node(value, next) ->
            printf("%A ") value;
            printList(next);

    let Head =
        function
        | Empty -> failwith "Nie mozna pobrac glowy z listy pustej";
        | Node(Head, _) -> Head;
 
    let Tail =
        function
        | Empty -> failwith "Nie mozna pobrac ogona z listy pustej";
        | Node(Tail, _) -> Tail;

    let addHead(value, list) =
        Node(value, list);

    let rec numberElements = 
        function
        | Empty -> 0;
        | Node (_, Tail) -> numberElements Tail + 1;

    let rec addAfter element newElement =
        function
        | Empty -> failwith("Nie znaleziono elementu: " + element.ToString());
        | Node (Head, Tail) ->
            if Head = element then
                Node(element, Node (newElement, Tail))
            else
                Node(Head, addAfter element newElement Tail)

    let rec sumList =
        function
        | Empty -> 0;
        | Node (Head, Tail) ->
            Head + sumList(Tail);

    let rec findMinMax list =
        match list with
        | Empty -> failwith("Lista jest pusta, brak elementow do porownania");
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
    let mutable userList = LinkedList.Empty;

    userList <- readUserList();

    LinkedList.printList userList;
    printfn("");
    printfn("Suma: %d") (LinkedList.sumList(userList));
    
    let cos = LinkedList.findMinMax(userList);
    let cos2 = LinkedList.reverseList(userList)

    printfn("Min: %d, Max: %d") (fst(cos)) (snd(cos));
    printfn $"{cos2}"

    

    0;

    

            
