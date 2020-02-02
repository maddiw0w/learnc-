using System;

namespace urok3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 4, 5, 7 };
            foreach (var item in nums)
            {
                Write(item);
            }
            Console.ReadKey();
        }
        static void Write(int item) => Console.WriteLine($"Сколько будет 1+2 {Summ(x:item)}");
        static int Summ(int x, int y = 3)
        {
            return x + y;
        }
    }
}
