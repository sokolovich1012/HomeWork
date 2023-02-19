double[,] myArrey=new double[3,4];
Random random = new Random();

for (int i = 0; i < myArrey.GetLength(0); i++)
{
    for (int j = 0; j < myArrey.GetLength(1); j++)
    {
      myArrey[i,j]= random.Next(-10,10) + random.NextDouble();  
    }
}

for (int y = 0; y < myArrey.GetLength(0); y++)
{
    for (int x = 0; x < myArrey.GetLength(1); x++)
    {
        Console.Write(myArrey[y,x] + " ");
    }
    Console.WriteLine();
}