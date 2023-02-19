int [,] myArrey=
{
    {1,2,3,4},
    {5,6,7,8}
};
Console.WriteLine("enter you index: ");
int ind = int.Parse (Console.ReadLine());
for (int i = 0; i < myArrey.GetLength(0); i++)
{
    for (int j = 0; j < myArrey.GetLength(1); j++)
    {
        if(myArrey[i,j]== ind)
        {
            Console.Write(i);
        }
        else
        {
            Console.Write("There is no element at that index.");
        }
    }
    Console.WriteLine();
}