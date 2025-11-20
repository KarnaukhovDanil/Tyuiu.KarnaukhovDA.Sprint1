using Tyuiu.KarnaukhovDA.Sprint1.Task4.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                             *");
        Console.WriteLine("* Тема: ClassMath                                                                                       *");
        Console.WriteLine("* Задание #4                                                                                            *");
        Console.WriteLine("* Вариант #5                                                                                            *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("* Написать программу которая запрашивает у пользователя исходные данные,                                *");
        Console.WriteLine("* вычисляет результат по формулe и печатает его на экране                                               *");
        Console.WriteLine("*                                                                                                       *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        int x, y;

        Console.WriteLine("Введите значение Х:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("1/(x+√y) =" + ds.Calculate(x, y));

        Console.ReadKey();
    }
}