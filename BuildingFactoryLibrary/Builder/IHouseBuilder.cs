
namespace BuildingFactoryLibrary.Builder;


public interface IHouseBuilder
{
    public IHouseBuilder SetHight(float hight);
    public IHouseBuilder SetFloorCount(int floorCount);
    public IHouseBuilder SetFlatCount(int flatCount);
    public IHouseBuilder SetEntranceCount(int entranceCount);

}
