 //sort by value

            Dictionary<int, string> My_dict1 =
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
            Console.ReadLine();

            //sort by key

            Dictionary<int, string> My_dict1 =
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
            Console.ReadLine();
            

