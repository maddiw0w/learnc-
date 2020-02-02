using System;

namespace urok1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Здраствуйте,  как вас зовут?");
                    var name = Console.ReadLine();
                    var answerNumber = 4;
                    Console.WriteLine($"Очень приятн, {name}");
                    Console.WriteLine($"{name}, скажите сколько будет 2+2= ");
                    var input = Convert.ToInt32(Console.ReadLine());
                    if (input == answerNumber)
                    {
                        Console.WriteLine($"{name}, и ваш ответ верный, 10 очков грифендору");
                        Console.WriteLine("Нажмите ENTER чтобы начать снова");
                    }
                    else
                    {
                        Console.WriteLine($"{name} - {input}, нет - ты что стебешься?");
                        Console.WriteLine("Нажмите ENTER чтобы начать снова");
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine("Вы ввели какое то гавно");
                    Console.WriteLine("Нажмите ENTER чтобы начать снова");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Вы ввели какое то гавно дважды");
                }
                Console.ReadKey();
            }
        }
    }
}
