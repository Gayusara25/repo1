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
