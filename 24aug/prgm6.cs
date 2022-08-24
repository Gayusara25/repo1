using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codereusable
{
      public class prgm6
    {
        public static void dateprop()
        {
            System.DateTime moment = new System.DateTime(2001, 10, 25, 10, 48, 11, 09);

            Console.WriteLine("year = " + moment.Year);

            Console.WriteLine("month = " + moment.Month);

            Console.WriteLine("day = " + moment.Day);

            Console.WriteLine("hour = " + moment.Hour);

            Console.WriteLine("minute = " + moment.Minute);

            Console.WriteLine("second = " + moment.Second);

            Console.WriteLine("millisecond = " + moment.Millisecond);

            
        }
    }
}
