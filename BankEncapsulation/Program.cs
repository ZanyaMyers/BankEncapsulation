namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank_Account account = new Bank_Account(); // creating the bank account 

            Console.WriteLine("Enter amount to deposit");
            double userInput = double.Parse(Console.ReadLine()); 
            account.Deposit(userInput);
            Console.WriteLine("");
            Console.WriteLine("Amount of money available:");
            account.GetBalance();
        }
    }
}
