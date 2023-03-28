using gbOOP.ls2;
using System.Text;


class Programm
{
    static void Main(string[] args)
    {
        StateTest t = StateTest.LoadState();
        t.Info();
        t.SaveState();

    }


}
