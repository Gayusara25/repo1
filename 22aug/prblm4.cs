ArrayList a = new ArrayList();
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
