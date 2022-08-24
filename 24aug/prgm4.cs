using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codereusable
{
    public class prgm4
    {
        public static void Upper()
        {
            String s= "Hello World";

            String res = s.ToUpper();
            Console.WriteLine($"Original String : {s}");
            Console.WriteLine($"Uppercase String : {res}");
        }

    }
}
