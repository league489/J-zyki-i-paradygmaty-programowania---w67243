module z5
//Wersja rekurencyjna
//let rec quicksort lista =
//    match lista with
//    | [] -> []
//    | pivot :: tail ->
//        let smaller = tail |> List.filter (fun x -> x <= pivot)
//        let larger = tail |> List.filter (fun x -> x > pivot)
//        (quicksort smaller) @ [pivot] @ (quicksort larger)

//    let lista = [3; 1; 4; 1; 5; 9; 2; 6; 5; 3; 5]
//    let posortowana = quicksort lista

//    printfn "%A" posortowana


//Wersja iteracyjna
//let iterativeQuicksort lista =
//    let stack = System.Collections.Generic.Stack<_>()
//    stack.Push(lista)
    
//    let mutable sorted = []

//    while stack.Count > 0 do
//        let l = stack.Pop()
//        match l with
//        | [] -> ()
//        | [x] -> sorted <- x :: sorted
//        | pivot :: tail ->
//            let smaller = tail |> List.filter (fun x -> x <= pivot)
//            let larger = tail |> List.filter (fun x -> x > pivot)
//            if larger <> [] then stack.Push(larger)
//            stack.Push([pivot])
//            if smaller <> [] then stack.Push(smaller)

//    List.rev sorted


//    let lista2 = [3; 1; 4; 1; 5; 9; 2; 6; 5; 3; 5]
//    let posortowana2 = iterativeQuicksort lista2

//    printfn "%A" posortowana2
