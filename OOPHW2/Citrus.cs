using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW2
{
    public class Citrus : Fruits
    {
        protected string _plantType;
        public Citrus(string name, int nrSeeds, string plant)
        {
            base._name = name;
            base._numberSeeds = nrSeeds;
            _plantType = plant;
        }

        public string GetPlantType()
        {
            return _plantType;
        }
    }
}
