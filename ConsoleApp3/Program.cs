using System;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Введите {i + 1} слагаемое");
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + array[i];

            }
            Console.WriteLine(" ");
            Console.WriteLine("Ответ: " + sum);
            Console.ReadKey();
        }
    }
}