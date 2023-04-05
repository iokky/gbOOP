
using BuildingFactoryLibrary.Domain;
using System.Collections;

namespace BuildingFactoryLibrary.Factory;

public class SingleEntranceBuildingFactory : BuildingFactory
{
    private readonly float _hight;
    private readonly int _floorCount;
    private readonly int _flatCount;

    private readonly Hashtable _map = new();


    public SingleEntranceBuildingFactory(float hight, int floorCount, int flatCount)
    {
        _hight = hight;
        _floorCount = floorCount;
        _flatCount = flatCount;
    }

    public override IBuild GetBuid()
    {
        IBuild build = new SingleEntranceBuilding(_hight, _floorCount, _flatCount);
        _map.Add(build.GetHashCode(), build);
        return build;
    }

    public override Hashtable GetMap() => _map;
    public override void Remove(int code) => _map.Remove(code);

}
