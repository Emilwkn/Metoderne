using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class Program
    {
        /*
        private static void Print()
        {
            Console.WriteLine("Hello World from a method");
        }
        */

        /*
        private static void Print()
        {
            Console.Write("Indtast et hel tal: ");
            string input = Console.ReadLine();
            Console.WriteLine("tallet er: {0}", input);
        }
        */

        /*
        private static void PrintResult()
        {
            Console.Write("Indtast et tal: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast et tal: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            int resultat1 = input1 + input2;
            int resultat2 = input1 - input2;
            int resultat3 = input1 * input2;
            int resultat4 = input1 / input2;
            Console.WriteLine($"{input1} + {input2} = {resultat1}");
            Console.WriteLine($"{input1} - {input2} = {resultat2}");
            Console.WriteLine($"{input1} * {input2} = {resultat3}");
            Console.WriteLine($"{input1} / {input2} = {resultat4}");
        }
        */

        /*
        private static void IsEven()
        {
            bool heltal;
            Console.Write("Indtast et tal ");
            int input1 = int.Parse(Console.ReadLine());
            if (input1 % 2 == 0)
            {
                heltal = true;
            }
            else
            {
                heltal = false;
            }
            Console.WriteLine($"{input1} er et heltal '{heltal}'");
        }
        */

        /*
        private static void IsPositive()
        {
            bool tal;
            Console.Write("Indtast et tal: ");
            int input = int.Parse(Console.ReadLine());
            if (input >= 0)
            {
                tal = true;
            }
            else
            {
                tal = false;
            }
            Console.WriteLine("{0} er et positivt tal '{1}'", input, tal);
        }
        */

        /*
        private static void CalculateAndPrint()
        {
            Console.Write("indtast et tal: ");
            int input = int.Parse(Console.ReadLine());

            double result = Math.Sqrt(input);

            Console.WriteLine("Kvadratroden af {0} er {1}", input, result);
        }
        */

        /*
        private static void Max()
        {
            Console.Write("Indtast et kommatal: ");
            double input1 = double.Parse(Console.ReadLine());
            Console.Write("Indtast et kommatal: ");
            double input2 = double.Parse(Console.ReadLine());

            if (input1 > input2)
            {
                Console.WriteLine("{0} er størst", input1);
            }
            else if (input2 > input1)
            {
                Console.WriteLine("{0} er størst", input2);
            }
            else 
            {
                Console.WriteLine("Det er de samme tal");
            }
        }
        */


        private static void Max()
        {
            Console.Write("Indtast et heltal: ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("Indtast et heltal: ");
            int input2 = int.Parse(Console.ReadLine());
            if (input1 > input2)
            {
                Console.WriteLine("{0} er størst", input1);
            }
            else if (input2 > input1)
            {
                Console.WriteLine("{0} er størst", input2);
            }
            else
            {
                Console.WriteLine("Det er de samme tal");
            }
        }


        static void Main(string[] args)
        {
            Max();

            Console.ReadKey();
        }
    }
}
