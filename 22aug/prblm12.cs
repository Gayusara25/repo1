int[] arr = new int[6] { 9, 77, 25, 08, 63, 11 };
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
            Console.Read();
