using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04
{
    internal class Program
    {
      
        static void Main(string[] args, object а, danni a)
        {
            danni A = new danni();
            Console.WriteLine(" Kakvo qdi dnes ?: ");
            a.Name = Console.ReadLine();
            Console.WriteLine("Kolko puti qdi? :");
            a.Broi = int.Parse(Console.ReadLine());
           
            a.Izhod();

            if (a.Broi > 5)
            {
                Console.WriteLine(5*a.Broi); 
            }
            else
            {
                Console.WriteLine("Boikata ti e po malka ot 5");
            }
            Console.WriteLine("Pil li si neshto dnes ?");
            string dailine = Console.ReadLine();
             int cifra = int.Parse(Console.ReadLine());  
            if (dailine == "da")
            {
                Console.WriteLine("Kakvo si pil izberi cifra ot 1-4: ");
             
            }
            else
            {
                Console.WriteLine("Lek den");
            }
            if (cifra == 1)
            {
                Console.WriteLine("Ti si pil Vodka ");
            }
            else
            if (cifra == 2)
            {
                Console.WriteLine("Ti si pil Voda ");
            }
            if (cifra == 3) 
            {
                Console.WriteLine("Ti si pil martini ");
            }
            else
            if (cifra == 4) 
            {
                Console.WriteLine("Ti si pil uiski ");
            }
            a.pitieta = Console.ReadLine();
          List<int> nums = Console.ReadLine().Split('').Select(int.Parse).ToList();   
        }
    }
}
