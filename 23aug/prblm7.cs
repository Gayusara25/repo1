using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23aug
{
    internal class prblm7
    {
        public static void Main()
        {
            int num1 = 2580;
            int num2 = 0;

            try
            {
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)

            {
                Console.WriteLine("An exception ({0}) is occurred.", e.GetType().Name);
                Console.WriteLine("Message is:\n   {0}\n", e.Message);
                Console.WriteLine("Division of {0} by zero.", num1);
                Console.WriteLine("Stack Trace:\n   {0}\n", e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
