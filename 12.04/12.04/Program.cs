using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            grupa a = new grupa();
            a.Ime = "Atanas";
            a.Adres = "Unas";
            a.Ocenka = 2;
            a.Zdrasti();
            a.Zdravei();
            a.Zdra();
            grupa b = new grupa();
            b.Ime = "Baba";
            b.Adres = "Uvas";
            b .Ocenka = 3;
            b.Zdrasti();
            b.Zdravei();
            b.Zdra();
        }
    }
}
