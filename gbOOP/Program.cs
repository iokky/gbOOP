using BuildingFactoryLibrary.Domain;
using BuildingFactoryLibrary.Builder;

class Programm
{
    static void Main(string[] args)
    {
        HouseBuilder builder = new HouseBuilder();
        HouseBuildDirector director = new HouseBuildDirector(builder);

        director.Build(5, 10);
        Build house = builder.GetBuild();
        Console.WriteLine(house);
    }
}

