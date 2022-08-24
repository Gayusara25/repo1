using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codereusable
{
    public class prgm3
    {
        public static void splits()
        {
            string text = "hello good,morning.have/a great day";
            Console.WriteLine("splitting :" + text);

            string[] result = text.Split(' ', ',', '.', '/');

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }

        }
    }
}
