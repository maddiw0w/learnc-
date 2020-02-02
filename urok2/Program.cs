using System;

namespace urok2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
            bool two = false;
            Console.WriteLine("Сколько будет 1+1=");
            var number = Convert.ToInt32(Console.ReadLine());
            switch(number)
            {
                case 2:
                    two = true;
                    Console.WriteLine("Ответ 2");
                    break;
                default:
                    Console.WriteLine("НэВэрный");
                    break;
            }
            Console.WriteLine(two ? "molodec" : "hyeplett");
            }
        }
    }
}
