
using gbOOP.ls5;

class Programm
{
    static void Main(string[] args)
    {
        RationalNumber f = new(10, 5);
        RationalNumber s = new(10, 2);

        Console.WriteLine(f < s);
        Console.WriteLine(f.GetHashCode());
        Console.WriteLine(f);
    }
}

