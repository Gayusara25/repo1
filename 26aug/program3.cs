using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26aug
{
    internal class program3
    {
        public static void Main()
        {
            List<string> products=new List<string>();
            products.Add("pen");
            products.Add("pencil");
            products.Add("box");
            products.Add("chocolates");

            Console.WriteLine("products");
           
            foreach (string p in products)
            {
                
                Console.WriteLine(p);
                
            }
            Console.WriteLine("count is "+ products.Count);
            Console.WriteLine("---------------------------------------");

            products.Add("chips");
            
            foreach (string l in products)
            {
                
                Console.WriteLine(l);
                
                

            }
            Console.WriteLine("count after adding is "+products.Count);
            Console.WriteLine("---------------------------------------");

            products.Remove("box");
            products.Remove("pencil");
            Console.WriteLine("count after deleting is "+ products.Count);

            Console.WriteLine("products :");
            
            foreach (string l in products)
            {
                
                Console.WriteLine(l);
                
                
               
            }
            Console.Read();
        }
    }
}
