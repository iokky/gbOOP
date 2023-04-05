using System.Collections;
using BuildingFactoryLibrary.Domain;


namespace BuildingFactoryLibrary.Factory;

public class MultiEntranceBuildingFactory:BuildingFactory
{
    private readonly float _hight;
    private readonly int _floorCount;
    private readonly int _flatCount;
    private readonly int _entranseCount;

    private readonly Hashtable _map = new();

    public MultiEntranceBuildingFactory(float hight, int floorCount, int flatCount, int entranseCount)
    {
        _hight = hight;
        _floorCount = floorCount;
        _flatCount = flatCount;
        _entranseCount = entranseCount;
    }

    public override IBuild GetBuid()
    {
        IBuild build = new MultiEntranceBuilding(_hight, _floorCount, _flatCount, _entranseCount);
        _map.Add(build.GetHashCode(), build);
        return build;
    }

    public override Hashtable GetMap() => _map;
    public override void Remove(int code) => _map.Remove(code);
}
