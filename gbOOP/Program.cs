using gbOOP.ls2;

class Programm
{
    static void Main(string[] args)
    {
        Account account = new Account("credit", 12);
        account.Deposit(100);
        account.Withdraw(113);
        account.GetAccountInfo();
    }
}
