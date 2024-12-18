module z1
//open System
//open System.Collections.Generic

//type Book(title:string, author:string, pages:int) =
//    member this.Title = title
//    member this.Author = author
//    member this.Pages = pages

//    member this.GetInfo() =
//        printfn "Tytuł: %s \nAuthor: %s \nIlość stron %d" this.Title this.Author this.Pages
    

//type Library() =
//    let books =  System.Collections.Generic.List<Book>()

//    member this.AddBook(book:Book) =
//        books.Add(book)
//        printfn $"Dodano książkę {book.Title}"
//    member this.RemoveBook(book:Book) = 

//        if books.Contains(book) then
//            books.Remove(book) |>ignore
//            printfn $"Usunięto książkę {book.Title}"
//        else
//            printfn $"Książka {book.Title} nie została znaleziona"
//    member this.ListBooks() = 
//        printfn "Książki w bibliotece:"
//        for book in books do
//            book.GetInfo()


//type User(name:string, library:Library) = 
//    let borrowedBooks = List<Book>()
//    member this.Name = name
//    member this.BorrowedBooks = borrowedBooks
//    member this.BorrowBook(book:Book) =
//        this.BorrowedBooks.Add(book)
//        library.RemoveBook(book)
//        printfn $"{this.Name} wypożyczył książkę {book.Title}"
//    member this.ReturnBook(book:Book) =
//        if this.BorrowedBooks.Contains(book) then
//                    printfn $"{this.Name} zwrócił książkę {book.Title}"
//                    this.BorrowedBooks.Remove(book) |>ignore
//                    library.AddBook(book)
//                else
//                    printfn $"{this.Name} nie ma wypożyczonej książki {book.Title}"


//[<EntryPoint>]
//let main argv =
//    let library = Library()
   
//    let book1 = Book ("To","Stephen King",1102)
//    let book2 = Book ("Zew Cthulu","H.P. Lovecraft",600)
//    let book3 = Book ("Dom stu szeptów", "Graham Masterton", 350)

//    library.AddBook(book1)
//    library.AddBook(book2)
//    library.AddBook(book3)
//    printfn""
//    library.ListBooks()
//    printfn""
//    let  user1 = User("Janusz Nosacz",library)

//    user1.BorrowBook(book1)
//    printfn""
//    user1.BorrowBook(book2)
//    printfn""
//    user1.ReturnBook(book1)
//    printfn""
//    library.ListBooks()
//    0



