using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko 4isla shte vuvejdash:");
           
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolko puti shte zavurtash:");
            int k = int.Parse(Console.ReadLine());
            int[] Chisla = new int[n];
            int[] sum = new int[n];
            int i;
            for ( i = 0; i < n; i++) 
            {
                Console.Write("Kolko 4isla shte vuvejdash:");
                Chisla[i] = int.Parse(Console.ReadLine()); 
            }
            //Zavurtane\
            sum[i] = 0;
            for (int r = 1; r < n; r++)
            {
                for ( i = 0; i < n; i++) 
                {
                    sum[i] = (i + r) % n;
                    
                    Console.WriteLine(sum[i]);
                }
               
            }
        }
    }
}
