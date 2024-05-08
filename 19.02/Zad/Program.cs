using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadelqne na pamet
            double[]pari = new double[2];
            string[]vid_zakuska = new string[2];
            //Vhod
            for (int i = 0; i < pari.Length; i++)
            {
                Console.Write("Vuvedi Zakuska: ");
                vid_zakuska[i] = Console.ReadLine();
                Console.Write("Vuvedi Pari: ");
                pari[i] = double.Parse(Console.ReadLine());
            }
            //Izhod
            for (int i = 0; i < 2; i++)
            {
                
                Console.WriteLine(vid_zakuska[i] + "/" + pari[i] );

            }
           

        }
    }
}
