Hashtable ht = new Hashtable();
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
             Console.ReadLine();
