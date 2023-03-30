using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbOOP.ls4
{
    public class House
    {
        private static int _id = 1;
        private int _number;
        private int _height;




        private void SetId()
        {
            _number = _id++;
        }

        public House()
        {
            SetId();
        }

        public override string ToString() => _number.ToString();
    }
}
