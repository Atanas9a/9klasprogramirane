using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kak se kazvash: ");
            string name = Console.ReadLine();
            Ime ime = new Ime();
            ime.Name = Console.ReadLine();
            ime.Out();
          
        }
    }
}
