Console.Write("enter cord x1");
long x1 = long.Parse(Console.ReadLine());
Console.Write("enter cord y1");
long y1 = long.Parse(Console.ReadLine());
Console.Write("enter cord z1");
long z1 = long.Parse(Console.ReadLine());
Console.Write("enter cord x2");
long x2 = long.Parse(Console.ReadLine());
Console.Write("enter cord y2");
long y2 = long.Parse(Console.ReadLine());
Console.Write("enter cord z2");
long z2 = long.Parse(Console.ReadLine());

long length;
if ((x1>0)&&(x2>0))
{
    if (x1>x2)
    {
    length= x1 - x2;
    }
    else
    {
    length= x2 -x1 ;
    }
}
else if ((x1<0)&&(x2<0))
{
    if (x1>x2)
    {
        length= x2 -x1;
    }
    else
    {
        length= x1 - x2;
    }
}
else
{
    if (x1>x2)
    {
        length= x1 - x2;
    }
    else
    {
        length= x2 - x1;
    }
}
long width;
if ((y1>0)&&(y2>0))
{
    if (y1>y2)
    {
        width= y1 - y2;
    }
    else
    {
        width= y2 -y1;
    }
}
else if ((y1<0)&&(y2<0))
{
    if (y1>y2)
    {
     width= y2 - y1;
    }
    else
    {
     width= y1 - y2;
    }
}
else
{
    if (y1>y2)
    {
     width= y2 - y2;
    }
    else
    {
     width= y2 - y1;
    }
}
long Low;
if ((z1>0)&&(z2>0))
{
    if (z1>z2)
    {
    Low= z1-z2 ;
    }
    else
    {
     Low= z2 -z1 ;
    }
}
else if ((z1<0)&&(z2<0))
{
    if (z1>z2)
    {
        Low= z2 -z1;
    }
    else
    {
        Low= z1 - z2;
    }
}
else
{
    if (z1>z2)
    {
        Low= z1 - z2;
    }
    else
    {
        Low= z2 - z1;
    }
}
double result = Math.Sqrt(length*length+width*width+Low*Low);
Console.WriteLine($"lingth {result}");