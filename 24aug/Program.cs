using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codereusable;

namespace myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
              DateTime dt1 = new DateTime();
               dt1 = Convert.ToDateTime(Console.ReadLine());

               Console.WriteLine("enter your bday date");
               DateTime now = DateTime.Today;
               int age = now.Year - dt1.Year;
               if (dt1 > now.AddYears(-age))
                   age--;

               Console.WriteLine("age= "+age);
               Console.WriteLine("day = " + dt1.Day);
               Console.WriteLine("month = " +dt1.Month);
               Console.WriteLine("year = " + dt1.Year);
               Console.WriteLine("week = " + dt1.DayOfWeek);


               bool isLeapYear = DateTime.IsLeapYear(dt1.Year);
               Console.WriteLine("leap year or not "+isLeapYear);



               Console.ReadLine();   
            Console.WriteLine("enter the string");
           class1.printstring();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("compare two string ");
            prgm1.print();
           Console.WriteLine("-----------------------------------");
            Console.WriteLine("string copy from s1 to s2 ");
            prgm2.copystring();
            Console.WriteLine("-----------------------------------");
            prgm3.splits();
            Console.WriteLine("-----------------------------------");
            prgm4.upper();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("new file is created");
            prgm5.file();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("date properities");
            prgm6.dateprop();
            Console.WriteLine("-----------------------------------");
           Console.ReadLine();

        }
    }
}
