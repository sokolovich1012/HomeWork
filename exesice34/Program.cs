Console.Write("Enter the number of elements in the array:");
int elementsCount = int.Parse(Console.ReadLine());
int [] myArrey= new int[elementsCount];
Random rand = new Random();
for (int x = 0; x < myArrey.Length; x++)
        {
        myArrey[x] = rand.Next(100,999);
        Console.WriteLine(myArrey[x]);
        }
       int result = 0;
       for (int i = 0; i < myArrey.Length; i++)
       {
        if (myArrey[i]%2==0)
        {
            result++;
            
        }
       }
       Console.WriteLine (result);