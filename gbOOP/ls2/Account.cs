
namespace gbOOP.ls2;


public class Account
{
    enum AccountType
    {
        deposit,
        credit

    }

    private int _number;
    private decimal _amount;
    private AccountType _type;
    
    public int Number
    {
        get { return _number; }
        set { _number = value; }
    }

    public decimal Amount
    {
        get { return _amount;  }
        set { _amount = value; }
    }

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

}
