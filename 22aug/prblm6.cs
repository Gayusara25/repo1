 Stack st = new Stack();
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
             Console.ReadLine();
