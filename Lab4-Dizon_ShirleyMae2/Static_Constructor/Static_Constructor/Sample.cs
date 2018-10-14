using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class Sample
    {
        public string firstname, lastname;

        static Sample() {
            System.Console.WriteLine("Static constructor");


        }
        public Sample() {
            firstname = "Shirley";
            lastname = "Dizon";

        }


    }
}
