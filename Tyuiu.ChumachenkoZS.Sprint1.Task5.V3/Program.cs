using Tyuiu.ChumachenkoZS.Sprint1.Task5.V3.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint1.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполняла: Чумаченко З. С. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполняла: Чумаченко Злата Сергеевна | ИБКСб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу: Присвоить целой    *");
            Console.WriteLine("* переменной h третью от конца цифру в записи положительного целого числаk*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int k;

            Console.WriteLine("Введите значение k: ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"если k = {k}, то h = " + ds.Calculate(k));
            Console.ReadLine();
        }
    }
}
