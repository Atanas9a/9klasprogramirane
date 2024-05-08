using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] predmet = new string[3];
            int[] chas = new int[3];

            Console.WriteLine("Vhod");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Vuvedi 4as");
                predmet[i] = Console.ReadLine();
                Console.WriteLine("Vuvedi predmet");
                int[] chas2 = new int[3];
            }
            Console.WriteLine("Izhod 1");
            for (int i = 0; i < 3; i++)
            {
             Console.WriteLine("Chas" + chas[i] + "Predmet" + predmet[i]);
            }

            Console.WriteLine("Izhod 2");
            for (int i = 0;i < 3;i++) 
            {
                if (chas[i] >= 4)
                Console.WriteLine("Chas" + chas[i] + "Predmet" + predmet[i]) ;
            }
            Console.WriteLine("Izhod 3: Sortirane");
          Array.Sort(chas);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Chas" + chas[i] + "Predmet" + predmet[i]);
            }
            Console.WriteLine("Izhod 4");
            Array.Sort(predmet);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Chas" + chas[i] + "Predmet" + predmet[i]);
            }
            Console.WriteLine("Izhod 5");

            Array.Reverse(predmet);
            Array.Sort(predmet);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Chas" + chas[i] + "Predmet" + predmet[i]);

            }
             Console.WriteLine("Izhod 6");
            string nov_predmet = "matemetika";

            for (int i = 0; i < 3; i++)
            {
                if (predmet[i] == nov_predmet)
                {
                    Console.WriteLine("Chas" + chas[i] + "Predmet" + predmet[i]);
                }
            }
            Console.WriteLine("Izhod 7");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Chas" + chas[1] + "Predmet" + predmet[1]);
            }
        }
    }
}
