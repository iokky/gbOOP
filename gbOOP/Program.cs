using BuildingFactoryLibrary;
using BuildingFactoryLibrary.Factory;
using BuildingFactoryLibrary.Domain;

class Programm
{
    static void Main(string[] args)
    {
        BaseFactory.GetBuild(10);
        BaseFactory.GetBuild(18,2, 4);
        BaseFactory.GetBuild(28,12, 6);
        BaseFactory.Remove(54267293);

        foreach (var item in BaseFactory.GetMap())
        {
            Console.WriteLine(item);
        }
    }
}
