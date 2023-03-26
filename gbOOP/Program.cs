using gbOOP.ls2;

class Programm
{
    static void Main(string[] args)
    {
        Account account = new Account();
        account.Type = "credit";
        Console.WriteLine(account.Number);
        Account account2 = new Account();
        Console.WriteLine(account2.Number);
    }
}
