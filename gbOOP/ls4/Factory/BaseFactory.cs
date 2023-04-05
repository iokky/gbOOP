

using gbOOP.ls4.Domain;
using System.Collections;

namespace gbOOP.ls4.Factory;

public class BaseFactory
{

    private static Hashtable _map = new Hashtable();
    private BaseFactory() { }

    /// <summary>
    /// Многоэтажный и многоподъездный вариант сборки
    /// </summary>
    /// <param name="hight"></param>
    /// <param name="floorCount"></param>
    /// <param name="flatCount"></param>
    /// <param name="entranseCount"></param>
    /// <returns></returns>
    public static Build GetBuild(float hight, int floorCount, int flatCount, int entranseCount)
    {
        Build build = new Build(hight, floorCount, flatCount, entranseCount);
        _map.Add(build.GetHashCode(), build);
        return build;
    }

    /// <summary>
    /// Одноэтажный многоподъездный вариант сборки
    /// </summary>
    /// <param name="hight"></param>
    /// <param name="floorCount"></param>
    /// <param name="flatCount"></param>
    public static Build GetBuild(float hight, int floorCount, int flatCount)
    {
        Build build = new Build(hight, floorCount, flatCount);
        _map.Add(build.GetHashCode(), build);
        return build;
    }

    /// <summary>
    /// Частный одноэтажный дом
    /// </summary>
    /// <param name="hight"></param>
    public static Build GetBuild(float hight)
    {
        Build build = new Build(hight);
        _map.Add(build.GetHashCode(), build);
        return build;
    }


    public static Hashtable GetMap() => _map;
    public static void Remove(int code) => _map.Remove(code);
}
