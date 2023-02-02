Console.WriteLine("Enter numbers");
int numbers= int.Parse(Console.ReadLine());
if (numbers>99)
{
    int threenumber = numbers %10;
    Console.WriteLine (threenumber);
}
else
{
    Console.WriteLine ("no third digit");
}