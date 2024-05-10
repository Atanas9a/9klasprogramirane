using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasove
{
    internal class Ime
    {
        private String name;
       
        public String Name
        {
           get { return name; }
           set { name = value; }
        }
        public void Out()
        {
            Console.WriteLine("ZDR ! Az sam {0} i sam na mnog dobur.", name);
        }
    }
}
