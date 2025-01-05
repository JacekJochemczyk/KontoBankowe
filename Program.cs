namespace KontoBankowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123456789123", 2000);

            Console.WriteLine("Numer konta: " + account.GetAccountNumber());
            Console.WriteLine("Saldo: " + account.GetSaldo() + " zł");

            account.Wplata(500m);
            Console.WriteLine("Saldo po wpłacie: " + account.GetSaldo() + " zł");

            account.Wyplata(300m);
            Console.WriteLine("Saldo po wypłacie: " + account.GetSaldo() + " zł");

            try
            {
                account.Wyplata(3000m);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Błąd: " + ex.Message);
            }
        }

    }
}
