public delegate void DisplayMessage();
public class Program
{
    public static void Invalid()
    {
        Console.WriteLine("Invalid Balance");
    }
    public static void Low()
    {
        Console.WriteLine("Low Balance");
    }

    public static void Zero()
    {
        Console.WriteLine("Zero Balance");
    }
    public static void Main(string[] args)
    {
        BankAccount b1 = new BankAccount(2000);

        MyDelegate obj1 = new MyDelegate(b1.Credit);

        MyDelegate obj2 = new MyDelegate(b1.Debit);
        
        b1.ZeroBalance+= new DisplayMessage(Zero);
        b1.InsufficientBalance+= new DisplayMessage(Invalid);
        b1.LowBalance+= new DisplayMessage(Low);
        
        int creditresult = obj1.Invoke(3000);
        Console.WriteLine($"After amount Credited = {creditresult}");


        int debitresult = obj2.Invoke(3000);
        Console.WriteLine($"After amount Debited = {debitresult}");

        Console.WriteLine($"Current {b1.ToString()}");

    }
}