using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefAndPolice
{
    internal class Police : Person
    {
        public List<String> SizedItems { get; set; }
        public Police(int x, int y, int xdirection, int ydirection) : base(x, y, xdirection, ydirection)
        {
            SizedItems = new List<string> { }; //create new list for each police
        }
    }
}
