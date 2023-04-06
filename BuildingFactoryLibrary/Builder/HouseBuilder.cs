
using BuildingFactoryLibrary.Domain;

namespace BuildingFactoryLibrary.Builder;


public class HouseBuilder : IHouseBuilder
{
    private Build _build;

    public HouseBuilder()
    {
        _build = new();
    }
    public IHouseBuilder SetEntranceCount(int entranceCount)
    {
        _build.EntranceCount = entranceCount;
        return this;
    }

    public IHouseBuilder SetFlatCount(int flatCount)
    {
        _build.FlatCount = flatCount;
        return this;
    }

    public IHouseBuilder SetFloorCount(int floorCount)
    {
        _build.FloorCount = floorCount;
        return this;
    }

    public IHouseBuilder SetHight(float hight)
    {
        _build.Hight = hight;
        return this;
    }

    public Build GetBuild()
    {
        Build build = _build;
        _build = new();
        return build;
    }
}
