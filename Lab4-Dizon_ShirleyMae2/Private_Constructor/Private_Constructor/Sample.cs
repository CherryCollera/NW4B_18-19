using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    class Sample
    {
        public string firstname, lastname;
        public Sample(string x, string y) {
            firstname = x;
            lastname = y;


        }
        private Sample() {
            System.Console.WriteLine("Private Constructor with no parameters");


        }

    }
}
