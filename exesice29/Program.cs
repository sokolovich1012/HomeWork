Console.Write("Enter the number of elements in the array:");
int elementsCount = int.Parse(Console.ReadLine());
int [] arrey= new int[elementsCount];
for (int i = 0; i < arrey.Length; i++)
{
    Console.Write("Enter number masiv:/t");
    arrey[i]=int.Parse(Console.ReadLine());
}
Console.Write("[");
for (int i = 0; i < arrey.Length; i++)
{
    Console.Write(",");
    Console.Write(arrey[i]);
}
Console.Write("]");
