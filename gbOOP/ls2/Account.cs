
namespace gbOOP.ls2;


public class Account
{
    enum AccountType
    {
        deposit,
        credit

    }
    private static int _counter = 1;
    private int _number;
    private decimal _amount;

    private AccountType _type;

    private void SetNumber()
    {
        _number = _counter;
        _counter++;
    }

    public Account()
    {

    }
    public Account(decimal amount)
    {
        SetNumber();
        _amount = amount;
    }

    public Account(string type)
    {
        SetNumber();
        switch (type)
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

    public Account(string type, decimal amount):this(type)
    {
        SetNumber();
        _amount = amount;
    }

    public void GetAccountInfo() => Console.WriteLine($"Id:{_number} amoutn:{_amount} type:{_type}");

    public void Deposit(decimal deposit)
    {
        _amount += deposit;
        Console.WriteLine($"deposit by {deposit} is complete");
        Console.WriteLine($"amount is {_amount}");
    }

    public void Withdraw(decimal withdraw) 
    {
        if (_amount - withdraw > -1) 
        {
            _amount -= withdraw;
            Console.WriteLine($"withdraw by {withdraw} is complete");
            Console.WriteLine($"amount is {_amount}");
        }
        else
        {
            Console.WriteLine("not enougth credits");
        }
    }
}
