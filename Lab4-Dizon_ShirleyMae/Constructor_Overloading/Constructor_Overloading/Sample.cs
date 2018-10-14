using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    class Sample
    {
        public string firstname, lastname;
        public Sample() {
            firstname = "Shirley";
            lastname = "Dizon";


        }
        public Sample(string x, string y) {
            firstname = x;
            lastname = y;

        }

    }
}
