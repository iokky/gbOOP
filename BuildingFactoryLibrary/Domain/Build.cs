using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingFactoryLibrary.Domain;

public class Build
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

    /// <summary>
    /// Многоэтажный и многоподъездный вариант сборки
    /// </summary>
    /// <param name="hight"></param>
    /// <param name="floorCount"></param>
    /// <param name="flatCount"></param>
    /// <param name="entranseCount"></param>
    public Build(float hight, int floorCount, int flatCount, int entranseCount)
    {
        SetId();
        _higth = hight;
        _floorCount = floorCount;
        _flatCount = flatCount;
        _entranceCount = entranseCount;
    }

    /// <summary>
    /// Одноэтажный многоподъездный вариант сборки
    /// </summary>
    /// <param name="hight"></param>
    /// <param name="floorCount"></param>
    /// <param name="flatCount"></param>
    public Build(float hight, int floorCount, int flatCount)
    {
        SetId();
        _higth = hight;
        _floorCount = floorCount;
        _flatCount = flatCount;
        _entranceCount = 1;
    }

    /// <summary>
    /// Частный одноэтажный дом
    /// </summary>
    /// <param name="hight"></param>
    public Build(float hight)
    {
        SetId();
        _higth = hight;
        _floorCount = 1;
        _flatCount = 1;
        _entranceCount = 1;
    }

    public float GetFloorHeight() => _higth / _floorCount;
    public float GetFloatCountByEntrance() => _flatCount / _entranceCount;
    public float GetFloatCountByFloor() => _flatCount / _floorCount;
    public override string ToString() => $"Building_#{_number}";
}
