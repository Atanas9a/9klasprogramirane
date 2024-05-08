using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38u
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                for (int j = 0; j < args[i].Length; j++)
                { if (args[i][j] == '-')
                        Console.WriteLine("Gotovo");
                }
            }
        }
    }
}
