
namespace gbOOP.ls2;


public class Account
{
    enum AccountType
    {
        deposit,
        credit

    }
    private static int _counter = 1;
    public int Number { get; private set; }
    public decimal Amount { get; set; }

    private AccountType _type;

    public string Type
    {
        get
        {
            switch (_type)
            {
                case AccountType.deposit:
                    return "deposit";
                 
                case AccountType.credit:
                    return "credit";               
            }
            return String.Empty;
        }
        set
        {
            switch (value)
            {
                case "credit":
                    _type = AccountType.credit;
                    break;
                case "deposit":
                    _type = AccountType.deposit;
                    break;
                default:
                    Console.WriteLine("Wrong entring type");
                    break;
            }
        }
    }
    public Account()
    {
        Number = _counter;
        _counter++;
    }
}
