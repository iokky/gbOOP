namespace BuildingFactoryLibrary.Domain;

public class MultiEntranceBuilding: IBuild
{
    private static int _id = 1;
    private int _number;
    private float _higth;
    private int _floorCount;
    private int _flatCount;
    private int _entranceCount;

    public int Number
    {
        get;
    }
    public float Hight
    {
        get { return _higth; }
        set { _higth = value; }
    }

    public int FloorCount
    {
        get { return _floorCount; }
        set { _floorCount = value; }
    }

    public int FlatCount
    {
        get { return _flatCount; }
        set { _flatCount = value; }
    }

    public int EntranceCount
    {
        get { return _entranceCount; }
        set { _entranceCount = value; }
    }

    private void SetId()
    {
        _number = _id++;
    }

    public MultiEntranceBuilding(float hight, int floorCount, int flatCount, int entranseCount)
    {
        SetId();
        _higth = hight;
        _floorCount = floorCount;
        _flatCount = flatCount;
        _entranceCount = entranseCount;
    }


    public float GetFloorHeight() => _higth / _floorCount;
    public float GetFloatCountByEntrance() => _flatCount / _entranceCount;
    public float GetFloatCountByFloor() => _flatCount / _floorCount;
    public override string ToString() => $"MultiEntranceBuilding_#{_number}";
}
