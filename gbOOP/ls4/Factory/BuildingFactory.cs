using gbOOP.ls4.Domain;
using System.Collections;

namespace gbOOP.ls4.Factory;

public abstract class BuildingFactory
{
    public abstract IBuild GetBuid();
    public abstract Hashtable GetMap();
    public abstract  void Remove(int code);
}