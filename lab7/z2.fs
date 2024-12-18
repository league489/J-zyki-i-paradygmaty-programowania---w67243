module z2
open System
open System.Collections.Generic
type BankAccount(account_number:int,balance_hold:float) =
    let mutable currentBalance = balance_hold 
    member this.AccountNumber = account_number
    member this.Balance = currentBalance
    member this.Deposit(amount_d:float) =
        currentBalance <- (this.Balance + amount_d)
        printfn $"Przelano kwotę: {amount_d} na konto {this.AccountNumber}"
        printfn $"Nowy stan konta: {this.Balance}"
    member this.Withdraw(amount_w:float) =
        if this.Balance >= amount_w then
            currentBalance <- (this.Balance - amount_w)
            printfn $"Wypłacono kwotę: {amount_w} z konta {this.AccountNumber}"
            printfn $"Nowy stan konta: {this.Balance}"
        else
            printfn "Brak wystarczających środkow na koncie"
    member this.GetInfo() = 
        printfn$"Numer konta: {this.AccountNumber} , Stan konta:{this.Balance}"

type Bank() =
    let Accounts = Dictionary<int,BankAccount>()
    member this.CreateAccount(account_number:int,balance_hold:float) =
        let konto = new BankAccount(account_number,balance_hold)
        Accounts.Add(konto.AccountNumber,konto)
        printfn $"Konto o numerze {account_number} zostało utworzone"
    member this.GetAccount(account_number:int) =
        if Accounts.ContainsKey(account_number) then
            printfn $"Konto {account_number} znalezione"
            Some(Accounts.[account_number])
        else
            printfn "Nie znaleziono konta"
            None
    member this.UpdateAccount(accountNumber:int,balanceOperation:char,amount:float) =
        if Accounts.ContainsKey(accountNumber) then
            if(balanceOperation = 'd') then
                Accounts.[accountNumber].Deposit(amount)
            elif(balanceOperation = 'w') then
                Accounts.[accountNumber].Withdraw(amount)
            else
                printfn "Nieprawdiłowa operacja"

    member this.DeleteAccount(accountNumber:int) =
     if Accounts.ContainsKey(accountNumber) then
            printfn $"Konto {accountNumber} usunięte"
            Accounts.Remove(accountNumber)
        else
            printfn "Nie znaleziono konta"
            false

            
    

        
            
                
         
            






        //if List.find(account) then
        //printfn $"Numer konta: {account.AccountNumber} /n Saldo: {account.Balance}"

        

