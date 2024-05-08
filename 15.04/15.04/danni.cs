using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _15._04
{
    internal class danni
    {
        private string name;
        private int broi;
        internal string pitieta;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Broi
        {
            get { return broi; } 
            set {  broi = value; }
        }
        public void Izhod()
        {
            Console.WriteLine("Ti dnes si ql {0} puti i si ql {1}.", broi,name);
        }
        public void Izhod2()
        {
        }
        private string pitie;
        
        public string Pitie
        {
            get { return pitie; }
            set { pitie = value; }
        }
        public void Izhod3()
        {
        }
    }
}
