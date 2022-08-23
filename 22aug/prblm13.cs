int[] arr = new int[] { 1, 3, 5, 200, 22, 2244, 213, 111 };
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
