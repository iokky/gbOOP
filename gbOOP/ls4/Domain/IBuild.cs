
namespace gbOOP.ls4.Domain;

public interface IBuild
{
    public int Number { get; }
    public float Hight { get; set; }
    public int FloorCount { get; set; } 
    public int FlatCount { get; set; }
    public int EntranceCount { get; set; }

    public float GetFloorHeight();
    public float GetFloatCountByEntrance();
    public float GetFloatCountByFloor();
}
