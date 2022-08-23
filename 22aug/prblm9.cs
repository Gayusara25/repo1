float[] arr = new float[] { 1.1f, 9.5f, 6.5f, 7.4f, 5.7f, 9.4f };
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
