
using gbOOP.ls4.Domain;

namespace gbOOP.ls4.Factory
{
    public class SingleEntranceBuildingFactory : BuildingFactory
    {
        private float _hight;
        private int _floorCount;
        private int _flatCount;


        public SingleEntranceBuildingFactory(float hight, int floorCount, int flatCount)
        {
            _hight = hight;
            _floorCount = floorCount;
            _flatCount = flatCount;
        }

        public override IBuild GetBuid() =>  new SingleEntranceBuilding(_hight, _floorCount, _flatCount);
    }
}
