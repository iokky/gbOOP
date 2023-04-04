
using gbOOP.ls4.Factory;

class Programm
{
    static void Main(string[] args)
    {

        SingleEntranceBuildingFactory s = new(10, 5, 30);
        Console.WriteLine(s.GetBuid().EntranceCount);


        MultiEntranceBuildingFactory m = new(10, 5, 30, 4);
        Console.WriteLine(m.GetBuid());

    }
}
