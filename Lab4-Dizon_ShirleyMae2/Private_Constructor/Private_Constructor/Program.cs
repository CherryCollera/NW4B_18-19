using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample("Shirley","Dizon");
            Console.WriteLine(s.firstname+" "+s.lastname);
            Console.ReadLine();

        }
    }
}
