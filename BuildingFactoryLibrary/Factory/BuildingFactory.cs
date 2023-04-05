using System.Collections;
using BuildingFactoryLibrary.Domain;

namespace BuildingFactoryLibrary.Factory;

public abstract class BuildingFactory
{
    public abstract IBuild GetBuid();
    public abstract Hashtable GetMap();
    public abstract void Remove(int code);
}
