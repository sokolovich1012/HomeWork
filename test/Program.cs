﻿Console.Write("Enter numbers masive");
int elementsCount = int.Parse(Console.ReadLine());
int [] arrey= new int[elementsCount];
for (int i = 0; i < arrey.Length; i++)
{
    Console.Write("Enter number masiv:/t");
    arrey[i]=int.Parse(Console.ReadLine());
}
for (int i = 0; i < arrey.Length; i++)
{
    Console.Write(",");
    Console.Write(arrey[i]);
}
Console.Write("]");
