using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Purvi Vhod ");
            int[] nomer = new int[5];
            string[] ime = new string[5];
            for (int i = 0; i <= 5; i++)
            {
                Console.Write("1. Ime ");
                ime[i] = Console.ReadLine();
                Console.Write("1.Nomer ");
                nomer[i] = int.Parse(Console.ReadLine());
               
            }

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(ime[5] + "/" + nomer[5]);
            }
            //Izhod 3
            Console.WriteLine("Izhod 3");
            Console.WriteLine("Vuvedi kakvo ime da tursq");
         string name = Console.ReadLine();
            for (int i = 0; i <= 5; i++)
            {
                if (ime[i]== name)
                {  }


                Console.Write("1. Ime ");
                ime[i] = Console.ReadLine();
                Console.Write("1.Nomer ");
                nomer[i] = int.Parse(Console.ReadLine());
                  

            }

            }
        }
   }

