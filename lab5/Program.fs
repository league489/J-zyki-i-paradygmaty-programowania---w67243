//let rec sumRec n = 
//    if n <= 0 then 0
//    else n + sumRec(n-1)

let sumaTail n = 
  let rec sumaRecTail n acc = 
    if n <= 0 then 0
    else n + sumaRecTail(n-1) (acc+n)
  sumaRecTail n 0
let sumrec = sumaTail 5
printfn$"sumrec {sumrec}"

let numbers = [1;2;3;4]
let numbers1 = List.map(fun x -> x*x) numbers


//let rec Fibonacci n =
//    if n <=1 then n
//    else Fibonacci(n-1) + Fibonacci(n-2)

//let wynik = Fibonacci(4)
//printfn$"rek fib z 4 {wynik}"

let FibonacciTail n =
    let rec FibonacciRecTail n acc =
        if n <=1 then n
        else FibonacciRecTail(acc-1) + FibonacciRecTail(acc-2)
    FibonacciRecTail n 0
let wynik = FibonacciTail 4 
printfn$"rek fib z 4 {wynik}"
