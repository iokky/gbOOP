﻿
namespace BuildingFactoryLibrary.Domain;

public class SingleEntranceBuilding: IBuild
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

    public SingleEntranceBuilding(float hight, int floorCount, int flatCount)
    {
        SetId();
        _higth = hight;
        _floorCount = floorCount;
        _flatCount = flatCount;
        _entranceCount = 1;
    }


    public float GetFloorHeight() => _higth / _floorCount;
    public float GetFloatCountByEntrance() => _flatCount / _entranceCount;
    public float GetFloatCountByFloor() => _flatCount / _floorCount;
    public override string ToString() => $"SingleEntranceBuilding_#{_number}";
}
