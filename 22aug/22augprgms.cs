using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22augprgms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            /*int[] arr = new int[10]; 
    int i;  
       Console.Write("\n\nRead and Print elements of an array:\n");
       Console.Write("-----------------------------------------\n");	
  
    Console.Write("Input 10 elements in the array :\n");  
    for(i=0; i<10; i++)  
    {  
	    Console.Write("element - {0} : ",i);
	    arr[i] = Convert.ToInt32(Console.ReadLine());  		
    }  
  
    Console.Write("\nElements in array are: ");  
    for(i=0; i<10; i++)  
    {  
        Console.Write("{0}  ", arr[i]);  
                Console.Read();
    } 
    Console.Write("\n");
             Console.Read();*/


            //2

            /* int i,n;
   int[] a= new int[100];
   
       Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
       Console.Write("------------------------------------------------------------------------\n");
   
   Console.Write("Input the number of elements to store in the array :");
   n = Convert.ToInt32(Console.ReadLine());    
   
   
   Console.Write("Input {0} number of elements in the array :\n",n);
   for(i=0;i<n;i++)
      {
	  Console.Write("element - {0} : ",i);
	  a[i] = Convert.ToInt32(Console.ReadLine()); 
	  }
      
   Console.Write("\nThe values store into the array are : \n");
   for(i=0;i<n;i++)
     {
	   Console.Write("{0}  ",a[i]);
	 }
 
   Console.Write("\n\nThe values store into the array in reverse are :\n");
   for(i=n-1;i>=0;i--)
      {
	   Console.Write("{0} ",a[i]);
                Console.Read();
	  }
   Console.Write("\n\n");*/

            //3

            /* int i,n;
    int[] a= new int[100];
             Console.Write("Input the number of elements to store in the array :");
    n = Convert.ToInt32(Console.ReadLine());    


    Console.Write("Input {0} number of elements in the array :\n",n);
    for(i=0;i<n;i++)
       {
       Console.Write("element - {0} : ",i);
       a[i] = Convert.ToInt32(Console.ReadLine()); 
       }
    int sum=0;
             for(i=0;i<=n;i++)
             {
                 sum=sum+a[i];

             }
              Console.Write("sum is "+sum);
                 Console.Read();*/

            //4

            /*ArrayList a = new ArrayList();
            int x = 25;
            int y = 89;
            string d = "gayu";
            a.Add(x);
            a.Add(d);
            a.Add(y);

            foreach (object o in a)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("after removing");
            a.Remove(d);
            foreach (object o in a)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("count :" + a.Count);
            Console.ReadLine();
            */


            //5
           
            /*
              int[][] cls = new int[5][];
            cls[0] = new int[] { 10 };
            cls[1] = new int[] { 30 };
            cls[2] = new int[] { 52 };
            cls[3] = new int[] { 40 };
            cls[4] = new int[] { 65 };
            for (int i = 0; i < cls.Length; i++)
            {
                Console.WriteLine("Student from class {0}: ", i);
                for (int j = 0; j < cls[i].Length; j++)
                {
                    Console.WriteLine("No of student: {0}", cls[i][j]);
                }
                Console.ReadLine();

            }*/


            //6

            /* Stack st = new Stack();
             st.Push(1);
             st.Push(2);
             st.Push(3);


             Console.WriteLine("before pop:");
             foreach (Object obj in st)
             {
                 Console.WriteLine(obj);
             }

             Console.WriteLine("before pop count is"+st.Count);
             st.Pop();
             Console.WriteLine("after pop:");
             foreach (Object obj in st)
             {  
                 Console.WriteLine(obj);
             }

             Console.WriteLine("peek is "+st.Peek());
             Console.WriteLine("after pop count is " + st.Count);
             Console.ReadLine();*/




            //7

            /*Queue<int> a = new Queue<int>();
            a.Enqueue(5);
           a.Enqueue(10);
            a.Enqueue(15);
            a.Enqueue(20);
            a.Enqueue(25);
            foreach (var ele in a)
            {
                Console.WriteLine(ele);
               
            }
            Console.WriteLine("total count :" + a.Count);
            a.Dequeue();
            Console.WriteLine("after dequeuing total count :"+a.Count);
            Console.WriteLine("top most element is " + a.Peek());
            Console.ReadLine();*/

            //8

            /* Hashtable ht = new Hashtable();
             ht.Add(1, "It");
             ht.Add(2, "looks");
            ht.Add(3, "Good!!");

             Console.WriteLine("Key and Value pairs from hashtable before delete:");

             foreach (DictionaryEntry ele in ht)
             {
                 Console.WriteLine("{0} and {1} ", ele.Key, ele.Value);
             }
             ht.Remove(2);

             Console.WriteLine("Key and Value pairs from hashtable before delete:");
             foreach (DictionaryEntry ele in ht)
             {
                 Console.WriteLine("{0} and {1} ", ele.Key, ele.Value);
             }
             Console.ReadLine();*/

            //9
            /*float[] arr = new float[] { 1.1f, 9.5f, 6.5f, 7.4f, 5.7f, 9.4f };
            Array.Sort(arr);
            Console.WriteLine("ascending order : ");
            foreach (float value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
            Array.Reverse(arr);
            Console.WriteLine("descending order : ");
            foreach (float value in arr)
            {
                Console.Write(value + " ");
            }
            Console.ReadLine();

            */

            //10

            /*Dictionary<int, string> My_dict1 =
                      new Dictionary<int, string>();
            My_dict1.Add(1123, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "GeeksforGeeks");

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",
                          ele1.Key, ele1.Value);
            }
            Console.ReadLine();*/

            //11

            //sort by value

            /*Dictionary<int, string> My_dict1 =
                      new Dictionary<int, string>();
            My_dict1.Add(1123, "heyy");
            My_dict1.Add(1127, "how are you");
            My_dict1.Add(1125, "hiii");

            var myList = My_dict1.ToList();
            myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            foreach (var value in myList)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();*/

            //sort by key

            /*Dictionary<int, string> My_dict1 =
                      new Dictionary<int, string>();
            My_dict1.Add(1123, "heyy");
            My_dict1.Add(1127, "how are you");
            My_dict1.Add(1125, "hiii");

            var myList = My_dict1.ToList();
            myList.Sort((pair1, pair2) => pair1.Key.CompareTo(pair2.Key));

            foreach (var Key in myList)
            {
                Console.WriteLine(Key);
            }
            Console.ReadLine();*/




            //12


            /*int[] arr = new int[6] { 9, 77, 25, 08, 63, 11 };
            int i, max, min, n;
            // size of the array
            n = 5;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum element = {0}\n", max);
           
            Console.Write("Minimum element = {0}\n", min);
            Console.Read();*/

            //13
            /*int[] arr = new int[] { 1, 3, 5, 200, 22, 2244, 213, 111 };
            int res = 100;
            Console.WriteLine("Given Integer {0}: ", res);
            Console.WriteLine("Numbers larger than {0} = ", res);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > res)
                {
                    Console.WriteLine(arr[i]);
                    Console.ReadLine();
                }
                
            }
            */

            //14









        }
    }    
}
