using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            Sample s1 = new Sample();
            Console.WriteLine(s1.firstname + " " + s1.lastname);
            Console.ReadLine();


        }
    }
}
