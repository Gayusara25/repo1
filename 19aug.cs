using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _19AUGEXE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*int a;
            int b;
            int min;
            int max;

            //input numbers
            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            //finding max number using if-else
            if (a > b)
                max = a;
            else
                max = b;

            //finding min number using if else
            if (a < b)
                min = a;
            else
                min = b;

            //printing
            Console.WriteLine("Using if-else...");
            Console.WriteLine("Minimum number = {0}", min);
            Console.ReadLine();
            Console.WriteLine("Maximum number = {0}", max);
            Console.ReadLine();*/

            //2
            /* int num1, num2, num3;
             num1 = Convert.ToInt32(Console.ReadLine());
             num2 = Convert.ToInt32(Console.ReadLine());
             num3 = Convert.ToInt32(Console.ReadLine());
             if (num1 > num2)
             {
                 if (num1 > num3)
                 {
                     Console.Write("{0} is the largest!\n", num1);
                     Console.ReadLine();
                 }
                 else
                 {
                     Console.Write("{0} is the largest!\n", num3);
                     Console.ReadLine();
                 }
             }
             else if (num2 > num3)
             {
                 Console.Write("{0} is the largest!\n", num2);
                 Console.ReadLine();
             }
             else
                 Console.Write("{0} is the largest!\n", num3);
                  Console.ReadLine();*/

            //3
            /*char c1, c2;

Console.WriteLine("Enter the first character : ");
c1 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Enter the second character : ");
c2= Convert.ToChar(Console.ReadLine());

if (c1 == c2)
    Console.WriteLine("Both characters are equal");
else
    Console.WriteLine("Characters are not equal"); */

            //4

            /*string str1, str2;
            int flg = 0;
            int i = 0, l1, l2, yn = 0;

            Console.Write("\n\nCompare two strings whether they are equal or not :\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the 1st string : ");
            str1 = Console.ReadLine();

            Console.Write("Input the 2nd string : ");
            str2 = Console.ReadLine();

            l1 = str1.Length;
            l2 = str2.Length;
            
            if (l1 == l2)
            {
                for (i = 0; i < l1; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        yn = 1;
                        i = l1;

                    }
                }
            }
            if (l1 == l2)
                flg = 0;
            else if (l1 > l2)
                flg = 1;
            else if (l1 < l2)
                flg = -1;
            
            if (flg == 0)
            {
                if (yn == 0)
                {
                    Console.Write("\nThe length of both strings are equal and \nalso, both strings are same.\n\n");
                    Console.ReadLine();
                }
                else
                    Console.Write("\nThe length of both strings are equal \nbut they are not same.\n\n");
                Console.ReadLine();
            }
            else if (flg == -1)
            {
                Console.Write("\nThe length of the first string is smaller than second.\n\n");
                Console.ReadLine();
            }
            else
            {
                Console.Write("\nThe length of the first string is greater than second.\n\n");
                Console.ReadLine();
            }*/


            //5

            /*int num1, num2;
            Console.WriteLine("enter num1:");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("{0} is biggest", num1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} is biggest", num2);
                Console.ReadLine();
            }*/

            //6

            /*int y;
            Console.WriteLine("enter the year:");
            y=Convert.ToInt32(Console.ReadLine());

            if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year", y);
                Console.ReadLine();
            }
            else
                Console.WriteLine("{0} is not a leap year", y);
            Console.ReadLine();
            */

            //7


            /* double rl, phy, che, mat, total;
             double per;
             string nm, div;

             Console.Write("\n\n");
             Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
             Console.Write("-------------------------------------------------------------------------------");
             Console.Write("\n\n");


             Console.Write("Input the Roll Number of the student :");
             rl = Convert.ToInt32(Console.ReadLine());

             Console.Write("Input the Name of the Student :");
             nm = Console.ReadLine();

             Console.Write("Input  the marks of Physics : ");
             phy = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input  the marks of  Chemistry : ");
             che = Convert.ToInt32(Console.ReadLine());
             Console.Write("Input  the marks of mathematics : ");
             mat = Convert.ToInt32(Console.ReadLine());

             total = phy + che + mat;
             per = total / 3.0;
             if (per >= 60)
                 div = "First";
             else
             if (per < 60 && per >= 45)
                 div = "Second";
             else
                 if (per < 45 && per >= 35)
                 div = "Pass";
             else
                 div = "Fail";

             Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
             Console.ReadLine();
             Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", phy, che, mat);
             Console.ReadLine();
             Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);
             Console.ReadLine();*/

            //8

            /* for (int i = 1; i <= 5; ++i)
             {
                 for (int j = 1; j <= i; ++j)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
                 Console.ReadLine();

             }*/

            //9

            /*int n, sum=0;
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd numbers are :");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
            Console.ReadLine();*/

            //10

            /*int n, reverse = 0, rem;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
            Console.Read();*/

            //11
            /*int i, sum = 0;

            Console.Write("Numbers between 100 and 200, divisible by 9 : \n");
            for (i = 101; i < 200; i++)
            {
                Console.Write("{0}  ", i);
                sum += i;
            }
        
        Console.Write("\n\nThe sum : {0} \n", sum);
            Console.Read();*/


            //12

            /*int i, sum = 0;

        Console.Write("\n\n");
        Console.Write("Find the number and sum of all integer between 100 and 200, divisible by 9:\n");
        Console.Write("-----------------------------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Numbers between 100 and 200, divisible by 9 : \n");
        for (i = 101; i < 200; i++)
        {
            if (i % 9 == 0)
            {
                Console.Write("{0}  ", i);
                sum += i;
            }
        }
        Console.Write("\n\nThe sum : {0} \n", sum);
        Console.Read();*/


            //13


            /* int a;
             a=Convert.ToInt32(Console.ReadLine());
             if(a==0)
             {
                 Console.WriteLine("IT IS ZERO");
             }
             else if(a>100)
             {
                 Console.WriteLine("too large");
             }
             else if(a%10==0)
             {
                 Console.WriteLine("multiple of 10");
             }
             else if (a%2==0)
             {
                 Console.WriteLine("it is even");
             }
             else 
             {
                 Console.WriteLine("it is odd");
             }*/

            //14
            /*
            int a;
            a = Convert.ToInt32 (Console.Read());

            switch (a)
            {
               
                case int n when (a == 0):
                    Console.WriteLine("zero");
                    Console.Read();
                    break ;

                case int n when (a >= 100):
                    Console.WriteLine("large num");
                    Console.Read();
                    break;

                case int n when (a % 10==0 ):
                    Console.WriteLine("multiple of 10 and even " );
                    Console.Read();
                    break;

                case int n when (a % 2 == 0):
                    Console.WriteLine("even");
                    Console.Read();
                    break;
                case int n when (a % 2 == 1):
                    Console.WriteLine("odd");
                    Console.Read();
                    break;



            }
            Console.Read();
            */

            //15

            /*for (int a = 0, b = 25; a <= 25 & b >= 0; a++, b--)
            {
                if (a > b)
                {
                    Console.WriteLine("It's crossed");
                    break;

                }
                else
                {
                    Console.Write(a);
                    Console.WriteLine(b);
                }
            }*/

            //16

            /*int shots = 1;
            int score = 100;
           


            while (shots <= 4)
            {
                string result;
                Console.WriteLine("result is :");
                result = Console.ReadLine();
                if (result == "miss")
                {
                    score = score - 20;
                    shots += 1;
                    Console.Write(score);
                    Console.ReadLine();
                }
                else
                {
                    score = score + 10;
                    shots += 1;
                    Console.Write(score);
                    Console.ReadLine();
                }
              

                    }
            Console.Write(" total score is  :");
                Console.Write(score);
            Console.ReadLine();
            */

            
            
        }
    }
}
