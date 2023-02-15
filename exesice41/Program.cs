Console.Write("Enter elements massive :");
int elements= int.Parse(Console.ReadLine());
int[] myArrey= new int[elements];
int result = 0;
for (int i = 0; i < myArrey.Length; i++)
{
   Console.Write("Enter numbers:");
   myArrey[i]= int.Parse(Console.ReadLine());
}
foreach(int number in myArrey)
{
    if(number > 0)
    {
        result++;
    }
}
Console.WriteLine($"numbers>0 : {result}");