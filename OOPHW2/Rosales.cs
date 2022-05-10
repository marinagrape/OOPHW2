using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW2
{
    class Rosales : Fruits
    {
        protected int _numberFruit;
        public Rosales(string name, int nrFruit, int nrSeeds)
        {
            base._name = name;
            base._numberSeeds = nrSeeds;
            _numberFruit = nrFruit;
        }

        public int GetNrFruit()
        {
            return _numberFruit;
        }
        public void CalculateSeedsNumber(int nrFruit)
        {
            int sum = nrFruit * 20;
            Console.WriteLine(_name + " has " + _numberFruit + " number of fruits on one branch, and the total number of fruits" +
                " on a tree of 20 branches " + sum);
        }
    }
}
