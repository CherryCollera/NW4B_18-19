using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            Sample s1 = new Sample("Shirley","Dizon");
            Console.WriteLine(s.firstname + " " + s.lastname);
            Console.WriteLine(s1.firstname+ " " +s.lastname);
            Console.ReadLine();


        }
    }
}
