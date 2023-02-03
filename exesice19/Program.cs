Console.WriteLine("Enter five-digit number");
string num = Console.ReadLine();
string rev = string.Concat(num.Reverse());
Console.WriteLine(num == rev ? "yes" : "no");
