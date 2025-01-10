module z4


//Wersja rekurencyjna
//let rec hanoi(krazek:int, poczatkowy:string ,  docelowy:string, pomocniczy:string)=
//    if(krazek>0) then
//        hanoi(krazek-1,poczatkowy,pomocniczy,docelowy)
//        printfn $"Przenieś krazek{krazek} z {poczatkowy} na {docelowy}"
//        hanoi(krazek-1,pomocniczy,poczatkowy,docelowy)




//    hanoi(3,"A","B","C") 


//Wersja iteracyjna
//type Move = {
//    From: string
//    To: string
//}

//let iterativeHanoi n source target auxiliary =
//    let moves = System.Collections.Generic.Queue<_>()
    

//    let performMove fromTower toTower =
//        moves.Enqueue({ From = fromTower; To = toTower })
    

//    let numMoves = (1 <<< n) - 1 // 2^n - 1
//    let pegNames = [| source; auxiliary; target |]

//    for i in 1..numMoves do
//        let fromPeg = pegNames.[((i &&& (i - 1)) % 3)]
//        let toPeg = pegNames.[((i ||| (i - 1) + 1) % 3)]
//        performMove fromPeg toPeg


//    while moves.Count > 0 do
//        let move = moves.Dequeue()
//        printfn "Przenieś dysk z %s do %s" move.From move.To


//iterativeHanoi 3 "A" "C" "B"
