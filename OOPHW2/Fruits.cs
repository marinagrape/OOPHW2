using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW2
{
    public class Fruits
    {
        protected string _name;
        protected int _numberSeeds;

        public void PrintInfo()
        {
            Console.WriteLine("The fruit is - " + _name + " and the number of seeds in it is: " + _numberSeeds);
        }

        public int GetNumberSeeds()
        {
            return _numberSeeds;
        }

        public string GetName()
        {
            return _name;
        }

    }
}
