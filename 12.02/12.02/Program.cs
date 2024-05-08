using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko dushi shte vuvejdash");
            int n = int.Parse(Console.ReadLine());
            double[] pari = new double[n];
            string[] imena = new string[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vuvedi ime i familiq");
                imena[i] = Console.ReadLine();
                Console.WriteLine("Vuvedi kolko djobni imash");
                pari[i]= double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n;)
            { Console.WriteLine(imena[n] + "ima" + pari[n] + "lv."); } 

            Console.WriteLine("Izhod 2");
            for (int i = 0; i < n; i++)
            { 
                if (pari[i] >= 7)
                {
                    Console.WriteLine(imena[i] + "ima" + pari[i] + "lv.");
                }
            }
            Console.WriteLine("Izhod 3");
            for (int i = 0; i < n; i++)
            {


                Console.WriteLine( imena[n] + " ima " + ( pari[n] -2 ) + "lv.");

            }
           
       }
   }
}
