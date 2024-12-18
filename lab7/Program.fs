open z1
open z2

[<EntryPoint>]
let main argv =
    let bank = Bank()
    let konto = bank.CreateAccount(1,100.0)
    let konto2 = bank.CreateAccount(2,500.0)
    bank.GetAccount(1).Value.Deposit(100.0)
    bank.GetAccount(1).Value.Withdraw(50.0)
    bank.UpdateAccount(2,'w',200.0)
    bank.DeleteAccount(2)
    0