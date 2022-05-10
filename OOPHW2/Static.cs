using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW2
{
    public static class Static
    {
        static string name = "Marina";

        public static void PrintStaticMethod()
        {
            Console.WriteLine("____________________Static________________");
        }

        public static void CitrusExtended(this Citrus element)
        {
            element.PrintInfo();
            Console.WriteLine(name);
        }
    }
}
