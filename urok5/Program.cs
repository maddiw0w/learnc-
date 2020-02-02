using System;

namespace urok5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, 4, 5 };
            var sum = Addition(1,2,3,4);
            Console.WriteLine(sum);
        }
        static int Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
