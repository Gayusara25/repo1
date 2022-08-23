Queue<int> a = new Queue<int>();
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
            Console.ReadLine();
