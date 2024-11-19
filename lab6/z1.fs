module z1

let ZliczSłowa (text: string) =
    text.Split([|' '; '.'; ','; '\n'|], System.StringSplitOptions.RemoveEmptyEntries)
    |> Array.length

let SłowaiZnaki (tekst:string) = 
    let słowa:int = ZliczSłowa(tekst)
    let słowaS = string słowa
    let znaki:int = String.length(słowaS)
    znaki



let napis = "lorem ipsum dolor sidelis , domine "

SłowaiZnaki(napis)
  

