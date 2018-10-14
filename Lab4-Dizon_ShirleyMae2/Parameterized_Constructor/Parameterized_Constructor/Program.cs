using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterized_Constructor
{
    class Program
    {
        private static void Main(string[] args)
        {
            Sample s = new Sample("Shirley","Dizon");
            Console.WriteLine(s.firstname);
            Console.WriteLine(s.lastname);
            Console.ReadLine();

        }
    }
}
