// Create a Bank a class, with Debit & Credit method
// You can assign a default balance using constructor
// Credit method will accept the amount that needs to be added in balance
// Debit method will accept the amount that needs to be deducted from the balance.
// If amount is greater than balance raise an event → insufficient balance
// If balance is low (< 3000) raise an event low balance
// If balance is zero then raise an event zero balance.

public delegate int MyDelegate(int balance);
public class BankAccount
{
    public int Balance;

    public event DisplayMessage InsufficientBalance;
    public event DisplayMessage LowBalance;
    public event DisplayMessage ZeroBalance;
    public BankAccount(int Balance)
    {
        this.Balance = Balance;
    }

    public int Debit(int amount)
    {
        if(amount > Balance)
        {
            InsufficientBalance();
        }
        else
        {
        Balance-= amount;
        if(Balance == 0)
        {
            ZeroBalance();
        }
        else if(Balance < 3000)
        {
            LowBalance();
        }
        }
        return Balance;
    }

    public int Credit(int amount)
    {
         Balance+= amount;
        return Balance;
    }

    public override string ToString()
    {
        return $"Balance = {Balance}";
    }

}