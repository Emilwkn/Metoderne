using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2
{
    class Program
    {
        private static void PrintMenuHeader()
        {
            Console.WriteLine("*** Great Leaders ***");
        }
        private static void PrintMenuItem()
        {
            Console.WriteLine("1) Cow");
        }
        private static void PrintMenuItems()
        {
            Console.WriteLine("1) Tuvalu");
            Console.WriteLine("2) Nauru");
        }
        private static void PrintMenuItems3()
        {
            Console.WriteLine("1) Donald Trump");
            Console.WriteLine("2) Vladimir Putin");
            Console.WriteLine("3) Kim Jong-un");
        }
        static void Main(string[] args)
        {
            PrintMenuHeader();
            PrintMenuItems3();

            Console.ReadKey();
        }
    }
}
