module z6
let PodmieńSłowo(text:string)(szukane_słowo:string) =
   let tekst_f = List.ofArray(text.Split([|' '; '.'; ','; '\n'|], System.StringSplitOptions.RemoveEmptyEntries)) 
   let wyszukaj = tekst_f |> List.contains(szukane_słowo)
   if wyszukaj then
        printfn$"Wprowadź słowo do podmiany ze słowem {szukane_słowo}:"
        let doPodmiany = System.Console.ReadLine()
        let zmodyfikowanyTekst = text.Replace(szukane_słowo,doPodmiany)
        printfn $"{zmodyfikowanyTekst}"
   else 
        printfn $"Tekst nie zawiera podanego słowa" 
 
