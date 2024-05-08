using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _26._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi: ");
            int n = int.Parse(Console.ReadLine());
            string[] ime  = new string[n];
            double[] cena = new double[n];
            string[] br = new string[n];
            Console.WriteLine("Izhod 1");

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Ime na pitie ");
                ime[i] = Console.ReadLine();
                Console.WriteLine("Cena na Pitie ");
                cena[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Broi pitieta");
                br[i] = Console.ReadLine();
            }
            Console.WriteLine("Izhod 2");

            for (int i = 0; i < n; i++)
            {
                if (cena[i] >= 2.5)
                {
                    Console.Write(ime[i] + " / " + cena[i] + " / " + br[i]);
                }
            }
            Console.WriteLine("Izhod 3");

            for (int i = 0; i < n; i++)
            {
                if (cena[i] == 2 && ime[i] == "kafe")
                {
                    Console.Write(br[i]);
                }
            }
            Console.WriteLine("Izhod 4");

            Array.Sort(ime);
            for (int i = 0; i < n; i++)
            {
                Console.Write(ime[i] + " / " + cena[i] + " / " + br[i]);

            }
            Console.WriteLine("Izhod 5");

            //Ne moga e 
            Console.WriteLine("Izhod 6");
            int firstValue = 0;
            int lastValue = ime.Length - 1;
            int midValue = ime.Length  / 2;
            Console.WriteLine(ime[firstValue] + "/" + ime[midValue] + "/" + ime[lastValue]);

            Console.WriteLine("Izhod 7");

            for (int i = 0; i < n; i++)
            {
                if (ime[i] == "Kafe")
                {

                    Console.Write(ime[i] + " / " + cena[i] + " / " + br[i]);
                }
            }
        }
    }
}
