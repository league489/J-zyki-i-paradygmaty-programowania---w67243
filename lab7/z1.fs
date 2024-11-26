
module z1
open System.Collections.Generic
type Book(title:string, author:string, pages:int) =
    member this.Title = title
    member this.Author = author
    member this.Pages = pages

    member this.GetInfo() =
        printf "Tytuł: %s \nAuthor: %s \nIlość stron %d:" this.Title this.Author this.Pages


type User(name:string) = 
    member this.Name = name
    member this.BorrowedBooks = new List<Book>()
    member this.BorrowBook book:Book =
        this.BorrowedBooks.Add(book)
           