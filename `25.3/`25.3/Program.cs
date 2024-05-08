using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] pitie = new string[n];
            int[] kolichestvo = new int[n];
            int[] broi = new int[n];
            
            for (int i = 0; i < n; i++) 
            {

                Console.WriteLine("Kakvo shte piesh");
                 pitie[i] = Console.ReadLine();
                Console.WriteLine("Kolko shte piesh");
                kolichestvo[i] = int.Parse(Console.ReadLine());  

            }
            Console.WriteLine("Izhod 1");
            for (int i = 0;i < n; i++)
            {
                Console.WriteLine("Ti piesh" + pitie[i] + "samo" + kolichestvo[i] + "broiki");

            }
            Console.WriteLine("Izhod 2");
            for (int i = 0; i < n ; i++) 
            {
                Console.WriteLine("Tvoite" + kolichestvo[i] + "litra sa " + kolichestvo[i] * 1000 + "mililitri");

            }
            Console.WriteLine("Izhod 3");
            for (int i = 0; i < n; i++) 
            {
                if (broi[i] > 2)
                {
                    Console.WriteLine("Ti piesh" + pitie[i] + "samo" + broi[i] + "broiki");

                }
            }
            Console.WriteLine("Izhod 4");
            for (int i = 0; i < n ; i++)
            { 
             for (int j = 0; j < n +1; j++) 
                {
                    if (broi[j] <= broi[j + 1])
                    {
                        Console.WriteLine("Ti piesh" + pitie[j] + "samo" + broi[j] + "broiki");
                    }
                }
            }
            Console.WriteLine("Izhod 5");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (pitie[j] == pitie[j + 1])
                    {
                        Console.WriteLine("Ti piesh" + pitie[j] + "samo" + broi[j] + "broiki");
                    }
                }
            }
        }
    }
}
