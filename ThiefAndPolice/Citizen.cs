using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefAndPolice
{
    internal class Citizen : Person
    {
        public List<String> Belongings { get; set; }

        public Citizen(int x, int y, int xdirection, int ydirection) : base(x, y, xdirection, ydirection)
        {
            Belongings = new List<String> { }; //create new list for each citizen

            Belongings.Add("Watch");
            Belongings.Add("Keys");
            Belongings.Add("Money");
            Belongings.Add("Phone");

        }
    }
}
