//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Enter numbers");
int num = int.Parse(Console.ReadLine());
int a = 0;
while (num>0)
{
 a = a + num %10; 
 num = num / 10;
}
 Console.WriteLine (a);

