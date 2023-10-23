using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefAndPolice
{
    internal class Thief : Person
    {
        public int PrisonTime;
        public List<String> StolenItems { get; set; }
        public Thief(int x, int y, int xdirection, int ydirection):base(x,y,xdirection,ydirection)
        {
            StolenItems = new List<String> { }; //create new list for each thief
            PrisonTime = 0;


        } 

    }
}
