using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    class Program
    {
        private static void Menu1()
        {
            Console.WriteLine("*** Hovedmenu ***");
            Console.WriteLine("1) Gå til udregninger.");
            Console.WriteLine("2) Gå til tal.");
            Console.WriteLine("3) Afslut programmet.");
        }
        private static void Menu2()
        {
            Console.WriteLine("*** Udregninger ***");
            Console.WriteLine("1) Kvadrat og rod.");
            Console.WriteLine("2) Tilbage til hovedmenu.");
        }
        private static void Menu3()
        {
            Console.WriteLine("*** Tal ***");
            Console.WriteLine("1) Er tallet positivt?");
            Console.WriteLine("2) Er tallet lige?");
            Console.WriteLine("3) Tilbage til hovedmenu.");
        }
        private static void Udregning1()
        {
            Console.Write("Indtast et tal: ");
            double InputMath1 = double.Parse(Console.ReadLine());
            double Result1 = Math.Sqrt(InputMath1);
            Console.WriteLine($"Kvadratrodes af {InputMath1} er {Result1}");
            Console.ReadKey();
        }
        private static void IsPositiv()
        {
            Console.Write("Indtast et tal: ");
            double input1 = double.Parse(Console.ReadLine());
            if (input1 > 0)
            {
                Console.WriteLine($"{input1} er positivt");
            }
            if (input1 < 0)
            {
                Console.WriteLine($"{input1} er negativt");
            }
            Console.ReadKey();
        }
        private static void IsEven()
        {
            Console.Write("Indtast et tal: ");
            double input1 = double.Parse(Console.ReadLine());
            if (input1 % 2 == 0)
            {
                Console.WriteLine($"{input1} er et lige tal");
            }
            else
            {
                Console.WriteLine($"{input1} er ikke et lige tal");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            bool Run = true;
            while (Run)
            {
                Console.Clear();
                Menu1();
                string input1 = Console.ReadLine();
                if (input1 == "1")
                {
                    while (true)
                    {
                        Console.Clear();
                        Menu2();
                        string input2 = Console.ReadLine();
                        if (input2 == "1")
                        {
                            Udregning1();
                        }
                        if (input2 == "2")
                        {
                            break;
                        }
                    }
                }
                if (input1 == "2")
                {
                    while (true)
                    {
                        Console.Clear();
                        Menu3();
                        string input3 = Console.ReadLine();
                        if (input3 == "1")
                        {
                            IsPositiv();
                        }
                        if (input3 == "2")
                        {
                            IsEven();
                        }
                        if (input3 == "3")
                        {
                            break;
                        }
                    }
                }
                if (input1 == "3")
                {
                    Run = false;
                }
            }
            


        }
    }
}
