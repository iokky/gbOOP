
using gbOOP.ls4.Factory;

class Programm
{
    static void Main(string[] args)
    {
        /*        MultiEntranceBuildingFactory m = new(10, 5, 50, 2);
                SingleEntranceBuildingFactory s = new(20, 12, 30);
                s.GetBuid();
                s.GetBuid();

                m.GetBuid();
                m.GetBuid();
                //s.BuildDel(54267293);
                foreach (var item in s.GetMap())
                {
                    Console.WriteLine(item);
                }


                Console.WriteLine(s.GetMap()[54267293]);
                m.Remove(33736294);

                foreach (var item in m.GetMap())
                {
                    Console.WriteLine(item);
                }*/

        BaseFactory.GetBuild(2);
        BaseFactory.GetBuild(10, 5, 50, 2);
        BaseFactory.GetBuild(20,12,30);
        BaseFactory.Remove(54267293);
        foreach (var item in BaseFactory.GetMap())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(BaseFactory.GetMap()[54267293]);
        BaseFactory.Remove(54267293);
        Console.WriteLine(BaseFactory.GetMap()[54267293]);
    }


}
