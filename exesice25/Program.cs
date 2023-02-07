Console.WriteLine("Enter one number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter two number");
int b = int.Parse(Console.ReadLine());
int c = Pow(a,b);
int Pow(int num, int n)
{
	int res = num;
	for (int i = 1; i < n; i++)
	{
		res *= num;
	}
	return res;
}
Console.WriteLine(c);