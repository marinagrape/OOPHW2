using System;
using System.Collections.Generic;
using System.Text;

namespace OOPHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Citrus orange = new Citrus("Orange", 4, "Tree");
            Citrus lemon = new Citrus("Lemon", 8, "Tree");
            Rosales apple = new Rosales("Apple", 10, 200);
            Rosales pear = new Rosales("Pear", 5, 100);

            apple.CalculateSeedsNumber(apple.GetNrFruit());
            lemon.GetName();

            orange.PrintInfo();
            //static method
            Static.PrintStaticMethod();
            lemon.CitrusExtended();
        }
    }
}
