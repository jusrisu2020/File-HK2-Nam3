using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 5, 2, 3, 4, 6 };
            int sum = 0;
            foreach(int item in array)
            {
                Console.Write("\t" +item);
                sum += item;
            }
            Console.WriteLine("\nSum = " +sum);
            Console.ReadLine();
        }
    }
}
