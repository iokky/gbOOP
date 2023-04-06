namespace BuildingFactoryLibrary.Builder;

public class HouseBuildDirector
{
    private IHouseBuilder _builder;
    public HouseBuildDirector(IHouseBuilder builder)
    {
        _builder = builder;
    }

    public void Build(float hight, int floorCount, int flatCount = 0, int entranseCount = 0)
    {
        _builder.SetHight(hight);
        _builder.SetFloorCount(floorCount);
    }
}
