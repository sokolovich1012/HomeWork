Console.WriteLine ("Enter numbers"); 
int num = int.Parse(Console.ReadLine());
if (num>0)
{
int count = 1;
while (count<num)
{
 Console.Write(count*count*count+",");
 count++;
}
Console.WriteLine(count*count*count+".");
}