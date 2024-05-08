using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._04
{
    internal class grupa
    {
       private string ime;
       private double ocenka;
       private string adres;
        
        public string Ime 
        {
            get { return ime; }
            set { ime = value; }
        }
        
        public string Adres 
        { 
            get { return adres; }
            set { adres = value; }
        }
        public double Ocenka 
        {
            get { return ocenka; }
            set { ocenka = value; }
        }
        public void Zdrasti() 
        {
            Console.WriteLine("Zdrasti az sym {0} i sym ot {1} imam ocenka {2}.",ime,adres, ocenka);
        }
        public void Zdravei()
        {
            Console.WriteLine($"Zdrasti az sym {ime} i sym ot {adres} imam ocenka {ocenka}");
        }
        public void Zdra()
        {
            Console.WriteLine($" Zdrasti az sym " + ime + " i sym ot " +  adres + " imam ocenka " +ocenka);
        }
    }
}
