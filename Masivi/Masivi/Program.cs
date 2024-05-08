using System.ComponentModel.Design;
using System.Diagnostics;

namespace Masivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            int[] nomer = new int[n];
            double[] ocenka = new double[n];
            string[] predmet = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Vyvedi danni za student {i + 1}:");
                Console.WriteLine("Ime: ");
                ime[i] = Console.ReadLine();
                Console.WriteLine("Nomer v klasa: ");
                nomer[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Predmet: ");
                predmet[i] = Console.ReadLine();
                Console.WriteLine("Ocenka: ");
                ocenka[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ime: {ime[i]}, nomer v klas: {nomer[i]}, predmet: {predmet[i]}, Ocenka: {ocenka[i]}");

            }

            Console.WriteLine("Izhod 2");

            for (int i = 0; i < n; i++)
            {
                if (ocenka[i] >= 5.25)
                {
                    Console.WriteLine(ocenka[i] + " - " + ime[i]);
                }
                else 
                {
                    Console.WriteLine("Ocenkata na uchenika e tvurde niska!");
                }
            }

            Console.WriteLine("Izhod 3");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (ocenka[j] > ocenka[j + 1])
                    {
                        double swapVar = ocenka[j];
                        ocenka[j] = ocenka[j + 1];
                        ocenka[j + 1] = swapVar;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", ocenka));


            Console.WriteLine("Izhod 4");

            for (int i = 0; i < n; i++)
            {

                if (nomer[i] >= 5 && nomer[i] <= 10)
                {
                    Console.WriteLine($"Ima {ime[i]} s nomer" + nomer[i]);

                }
                else if (ime[i] == "Stako" || ime[i] == "atanas")
                {
                    Console.WriteLine($"Ima {ime[i]}, no nomera mu ne e mejdu 5 - 10({nomer[i]})");
                }
                else
                {
                    Console.WriteLine($"Nqma uchenik s ime {ime[i]}");
                }


            }

            Console.WriteLine("Izhod 5");

            List<int> sortedNumber = nomer.ToList();

            for (int i = 0; i < ime.Length; i++)
            {
                for (int j = 0; j < ime.Length + 1; j++)
                {
                    if (i == j)
                    {
                        sortedNumber.OrderByDescending(n => n).ToList();
                    }
                }

            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ime[i] + " " + sortedNumber[i]);
            }

            Console.WriteLine("Izhod 6");

            predmet.OrderBy(p => p).ToList().ForEach(p => Console.Write(p + " "));

            // edno kafe da kajesh na Hristozova da napravi na 12 a klas (na Ivaylo i Atanas)
        }
        
    }
}
