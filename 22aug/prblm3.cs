int i,n;
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
                 Console.Read();
