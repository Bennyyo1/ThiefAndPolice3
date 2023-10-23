using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefAndPolice
{
    public class Person
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int XDirection { get; set; }
        public int YDirection { get; set; }

        //Inventory in person class?

        public Person(int x, int y, int xdirection, int ydirection)
        {
            X = x;
            Y = y;
            XDirection = xdirection;
            YDirection = ydirection;
            
        }
    }

        
}
