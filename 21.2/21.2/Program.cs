using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko 4isla shte vuvejdash");
             int n = int.Parse(Console.ReadLine());

             string[] num = new string[n];












            int[] chisla = new int[5];
            for (int i = 0; i < 5; i++)
            {
               chisla[i] =int.Parse(Console.ReadLine());   
            }
          
            Console.WriteLine("Izhod bez posleden element ");
            for (int i = 0; i < 5-1; i++)
            {
                Console.WriteLine(chisla[i]);

            }
            Console.WriteLine("Izhod za triene na 2");
            for (int i = 0; i < 5 ; i++)
            {
                Console.WriteLine(" ", chisla);
                Console.WriteLine(chisla[i]);
            }





















            // for (int i = n-1; i > 0; i--)
            // {
            //    Console.WriteLine(num[i]);
            // }
            // Console.WriteLine("Izhod 2");
            // Console.WriteLine(num[1]);



        }
}
}
