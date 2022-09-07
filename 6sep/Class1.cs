using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class person
    {

        public abstract void work();

    }
    public class employees : person
    {


        public override void work()
        {
            Console.WriteLine("calling emplpoyee");
        }
    }
    public class manager : person
    {


        public override void work()
        {
            Console.WriteLine("calling manager");
        }
    }
    public class clerk : person
    {


        public override void work()
        {
            Console.WriteLine("calling clerk");
        }
    }
    public interface transaction
    {

        void print_balance();
        void calc_interest();
    }
    public class bank : transaction
    {

        public double amount;

        public bank()
        {

            amount = 0;
        }

        public void print_balance()
        {
            Console.WriteLine("ENTER THE AMOUNT");
            amount = Convert.ToDouble(Console.ReadLine());
        }
        public void calc_interest()
        {
            int r;
            Console.WriteLine("enter the interest to calculate");
            r = Convert.ToInt32(Console.ReadLine());
            double result = amount * r;
            Console.WriteLine("calc_interest " + result);
        }  }
    }
