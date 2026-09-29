using Tyuiu.ChumachenkoZS.Sprint1.Task3.V9.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint1.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполняла: Чумаченко З. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполняла: Чумаченко Злата Сергеевна | ИБКСб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу пересчета величины временного интервала,             *");
            Console.WriteLine("* заданного в минутах, в величину, выраженную в часах и минутах.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите временной интервал (в минутах) -> ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int hours = x / 60;
            int minutes = x % 60;
            Console.WriteLine($"{x} минут - это {hours} ч. {minutes} мин.");
            Console.ReadLine();
        }
    }
}
