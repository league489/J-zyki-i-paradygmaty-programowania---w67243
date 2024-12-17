open System
open System.Collections.Generic
// Definicja listy łączonej
type LinkedList<'T> =
 | Empty // Pusta lista
 | Node of 'T * LinkedList<'T> 

// Funckje przydatne podczas wykonywania operacji na głowie i ogonie
let Head =
 function
 | Empty -> failwith "Nie można pobrać głowy z listy pustej"
 | Node(Head,_) -> Head

let Tail =
 function
 | Empty -> failwith "Nie można pobrać ogona z listy pustej"
 | Node(Tail,_) -> Tail

// Funkcja dodająca element na początek listy
let addHead value list =
 Node(value, list)