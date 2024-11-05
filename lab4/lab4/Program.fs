//printfn "Hello from F#"
////let mutable x = 5
////let mutable  y = "Ala"
////printf "wartość liczby x =  %d twoje imie = %s" x y

//printfn "podaj imie"
//let name = System.Console.ReadLine()
//printfn "Podane imie: %s" name

//printfn "Podaj liczbę: "
//let liczba = System.Console.ReadLine()
//let number = int liczba
//printfn "Podana liczba: %d" number

//let x = 5
//let y = 221

//let mojeZapytanie =
//    if x > y then
//        "x jest większy"
//    else 
//         "y jest większy"
        
//let listaA = [1;2;3;4]
//let listaB = 0:: listaA

////for item in listaA do
////    printf "%d " item

//let listaC = listaA @ listaB

//for item in listaC do
//    printf "%d " item

//type Osoba ={
//    Imie: string;
//    Wiek: int;  }
//let sosba1 = {Imie = "Jan"; Wiek = 12}
//let osoba2 = {Imie = "Janina"; Wiek = 30}
//let krotka = (1, "ala", true)

//z1
type user = {
 Weight:float
 Height:float
}
let calculateBMI(User: user) =
    let HeightMeters = User.Height/100.0
    let bmi = User.Weight / (HeightMeters**2)
    bmi

let getBMICategory bmi =
    match bmi with
    | x when x < 18.0 -> "Niedowaga"
    | x when x >= 18.5 && x <= 20.99 -> "Waga prawidłowa"
    | x when x >= 21.0 -> "Nadwaga"
    |_ -> "Nie pykło"

[<EntryPoint>]
let main argv = 
    printfn "Podaj swoją wage w kg: "
    let weightInput = System.Console.ReadLine()
    let weightInputFloat = float.weightInput