using System.Text.Json;

namespace gbOOP.ls2;

public class Account
{
    enum AccountType
    {
        deposit,
        credit
    }
    private static int _counter = 1;


    public int _number;
    public decimal _amount;

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
            Console.WriteLine($"amount is {_amount}");
        }
    }

    public string SaveState()
    {
        return JsonSerializer.Serialize(this);
    }

    public override string ToString() => $"Id:{_number} amoutn:{_amount} type:{_type}";

}