
namespace ConsoleApplication1
{
    class Program
    {
        private static double max;

        static void Main(string[] args)
        {
            Double[] aMassiv;
            Console.WriteLine("Enter element numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            aMassiv = new Double[n];
            Random rnd = new Random();
            
            for (int i = 0; i < aMassiv.Length; i++)
                aMassiv[i] = rnd.Next(1, 10);
            Double min = aMassiv.Min(); 
            int p2 = 0;//2
            foreach (int i in aMassiv)
                if (i != min) p2 += i;
                else break;
            foreach (var i in aMassiv)
            {
                Console.Write(string.Format("{0:f3}\t\t", i )); 
            }
            Double max= aMassiv.Max();
            for (int i = 0; i < aMassiv.Length; i++)
            {
                if (aMassiv[i]>max)
                {
                    max=aMassiv[i];
                }
            }
            Double r=0;
            for (int i = 0; i < aMassiv.Length; i++)
            {
                if (max>min)
                {
                    r=max - min ;
                }
            }
            Console.WriteLine(".");
            Console.Write("max~min:");
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}