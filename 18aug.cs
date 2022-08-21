using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18aug
{
    internal class Program
    {
        static void SwapNum(ref int x, ref int y)
        {

            int tempswap =  x;
            x = y;
            y = tempswap;
        }
        static void Main(string[] args)
        {


            /*int a =5;
            int b =6;
            Console.WriteLine("Value of a and b before sawapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            SwapNum(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Value of a and b after sawapping");
            Console.WriteLine();
            Console.WriteLine("a=" + " " + a);
            Console.WriteLine("b=" + " " + b);
            Console.ReadLine();*/

            //2

            /* int num1,num2,num3;
             Console.Write("Input the first number to multiply: ");
             num1 = Convert.ToInt32(Console.ReadLine());

             Console.Write("Input the second number to multiply: ");
             num2 = Convert.ToInt32(Console.ReadLine());

             Console.Write("Input the third number to multiply: ");
             num3 = Convert.ToInt32(Console.ReadLine());

             int result = num1 * num2 * num3;
             Console.WriteLine("{0} x {1} x {2} = {3}",
                                 num1, num2, num3, result);
             Console.ReadLine();*/

            //3ques

            /*int num1, num2;
            Console.Write("Enter a  first number: ");
             num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
             num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.ReadLine();
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.ReadLine();
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.ReadLine();
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.ReadLine();
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
            Console.ReadLine();*/

            //4


            /*int num1, num2, num3, num4;
            Console.Write("Enter a  first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a  third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a fourth number: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            int Avg = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("avg of {0},{1},{2},{3} is ={4}",num1,num2,num3,num4,Avg);
            Console.ReadLine();*/

            //5

            /*int num;
            Console.WriteLine("Enter a digit: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Part A: "num num num num" using Write
            Console.Write(num);
            Console.ReadLine();
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.WriteLine();

            // Part B: "numnumnumnum" using Write
            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);
            Console.WriteLine();

            // Part C: "num num num num" using {0}
            Console.WriteLine("{0} {0} {0} {0}", num);

            // Part D: "numnumnumnum" using {0}
            Console.WriteLine("{0}{0}{0}{0}", num);*/


            //6
            /*int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look older than {0} ", age);
            Console.ReadLine();*/

            //7

            /*int number1, number2, number3;

            Console.Write("Enter first number - ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number - ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
                number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
            Console.ReadLine();*/







            //8

            /* int x;

             Console.Write("Enter a number: ");
             x = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("{0}{0}{0}", x);
             Console.ReadLine();
             Console.WriteLine("{0} {0}", x);
             Console.ReadLine();
             Console.WriteLine("{0} {0}", x);
             Console.ReadLine();
             Console.WriteLine("{0} {0}", x);
             Console.ReadLine();
             Console.WriteLine("{0}{0}{0}", x);
             Console.ReadLine();*/




            //9
            /*Console.Write("Enter the amount of Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.ReadLine();

            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            Console.ReadLine();*/

            //10

            /*Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            bool res = (x < 0 && y > 0) || (x > 0 && y < 0);
            Console.WriteLine(res);
            Console.ReadLine();*/


            //11
            /*int num1, num2;
            Console.Write("Enter first number - ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number - ");
            num2 = Convert.ToInt32(Console.ReadLine());

            bool res = (num2 > 0) && (num2 > 0);
            Console.WriteLine(res);
            Console.ReadLine();*/


            //12

            /*string s1 = " ";
            bool b1 = string.IsNullOrEmpty(s1);
            Console.WriteLine(b1);
            Console.ReadLine();*/


            //14

            double fahrenheit;

            double celsius;
            Console.WriteLine("Celsius : ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            Console.ReadLine();

            //15
            /*double usd;
            double inr;
            double value;

            Console.Write("Enter amount in USD: ");
            usd = double.Parse(Console.ReadLine());

            Console.Write("Enter the USD value :");
            value = double.Parse(Console.ReadLine());

            inr = usd * value;
            Console.WriteLine("USD " + usd + "-> INR " + inr);
            Console.ReadLine();*/

            //16
            
            String firstname;
            Console.Writeline("firstname is ");
            firstname=Console.Readline();
             String lastname;
            Console.Writeline("lastname is ");
            lastname=Console.Readline();
            string userid,password;
            if( firstname==userid&&lastname==password)
            {
                Console.Writeline("successfully logged in!!!");
                Console.Writeline("Welcome to my app");
            }
            else
            {
                Console.Writeline("Unsuccessful.. please check userid or password");
            }









        }
}
}
    

        
