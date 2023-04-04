

using gbOOP.ls4.Domain;
using System.Collections;

namespace gbOOP.ls4.Factory;

public class BaseFactory
{

    private Hashtable _hashtable = new Hashtable();
    private BaseFactory() { }

    public static IBuild GetBuild(float hight, int floorCount, int flatCount)
    {
        IBuild build = new SingleEntranceBuilding(hight, floorCount, flatCount);
        return build;
    }
    public static IBuild GetBuild(float hight, int floorCount, int flatCount, int entranseCount) => new MultiEntranceBuilding(hight, floorCount, flatCount, entranseCount);
}
