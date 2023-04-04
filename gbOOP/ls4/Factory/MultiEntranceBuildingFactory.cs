using gbOOP.ls4.Domain;

namespace gbOOP.ls4.Factory
{
    public class MultiEntranceBuildingFactory : BuildingFactory
    {
        private float _hight;
        private int _floorCount;
        private int _flatCount;
        private int _entranseCount;

        public MultiEntranceBuildingFactory(float hight, int floorCount, int flatCount, int entranseCount)
        {
            _hight = hight;
            _floorCount = floorCount;
            _flatCount = flatCount;
            _entranseCount = entranseCount;
        }

        public override IBuild GetBuid() => new MultiEntranceBuilding(_hight, _floorCount, _flatCount, _entranseCount);
    }
}
