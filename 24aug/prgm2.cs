using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codereusable
{
    public class prgm2
    {
        public static void copystring()
        {
            string s1 = "welcome ";
            string s2 = string.Copy(s1);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
