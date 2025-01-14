module z4

//let Posortuj (lista: int list) =
//    let mutable zamiana = true
//    let array = List.toArray lista
//    while zamiana do
//        zamiana <- false
//        for i in 0 .. (Array.length array - 2) do
//            if array.[i] > array.[i + 1] then
//                let temp = array.[i]
//                array.[i] <- array.[i + 1]
//                array.[i + 1] <- temp
//                zamiana <- true
//    Array.toList array

//      let lista = [3; 1; 4; 1; 5; 9; 2; 6; 5]
//    let posortowanaLista = Posortuj lista
//    printfn "%A" posortowanaLista  