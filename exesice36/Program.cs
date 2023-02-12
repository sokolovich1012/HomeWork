namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum1 = 0, sum2 = 0;
            Random rand = new Random();
            int[] a;
            Console.WriteLine("Enter one\n");
            int v = int.Parse(Console.ReadLine());
            if (v == 1)
            {
                Console.Write("Enter the size of the array: ");
                n = int.Parse(Console.ReadLine());
                a = new int [n];
                Console.Clear();
                Console.WriteLine("Исходный массив:");
                for (int i = 0; i < n; i++)
                {
                    a[i] = rand.Next(-10,10);
                    Console.Write("{0,5}", a[i]);
                }
                Console.WriteLine();
            }
            else
            {
                n = rand.Next(10); 
                a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Введите значение элемента {0}: ",i);
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine("Исходный массив из {0} элементов: ",n);
                for (int i = 0; i < n; i++)
                    Console.Write("{0,4 }", a[i]);
                Console.WriteLine();
            }
          
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                  sum1 = sum1 + a[i];
                else
                  sum2 = sum2 + a[i];
            }
            Console.WriteLine("Сумма элементов с нечетными номерами (нумерация начинается с нуля): {0} ", sum2);

            Console.ReadKey();
        }
    }
}