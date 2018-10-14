using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constuctor
{
    class Program
    {
        static void Main(string[] args)
        {

            Sample s = new Sample("Shirley", "Dizon");
            Sample s1 = new Sample(s);
            Console.WriteLine(s);
            Console.WriteLine("\n"+s1.firstname+"\n\n"+s1.lastname);
            Console.ReadLine();
        }
    }
}
