
namespace gbOOP.ls4
{
    public class Creator
    {
        private  static Creator _instance;

        private Creator() 
        {

        }

        public static  Creator GetInstanse() 
        {
            if (_instance == null)
            {
                _instance = new Creator();
            }
            return _instance;
        }

        public House GetBuild() => new House();
    }
}
