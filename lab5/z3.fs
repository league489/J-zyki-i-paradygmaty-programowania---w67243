module z3
//let rec permutacje lista =
//    let rec helper acc pre lista =
//        match lista with
//        | [] -> [List.rev pre]
//        | _ ->
//            lista
//            |> List.collect (fun x ->
//                let remaining = List.filter ((<>) x) lista
//                helper acc (x :: pre) remaining)
//    helper [] [] lista

//    let lista = [1; 2; 3;4]
//    let wyniki = permutacje lista

//    wyniki |> List.iter (printfn "%A")
        
