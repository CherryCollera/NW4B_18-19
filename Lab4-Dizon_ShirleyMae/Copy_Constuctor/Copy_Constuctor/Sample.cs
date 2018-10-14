using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constuctor
{
    class Sample
    {
        public string firstname, lastname;
        public Sample(string x,string y) {
            firstname = x;
            lastname = y;



        }
        public Sample(Sample s) {
            firstname = s.firstname;
            lastname = s.lastname;



        }



    }
}
