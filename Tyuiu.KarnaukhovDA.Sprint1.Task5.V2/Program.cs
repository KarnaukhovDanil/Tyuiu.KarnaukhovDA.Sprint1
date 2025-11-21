using Tyuiu.KarnaukhovDA.Sprint1.Task5.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                             *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                                                            *");
        Console.WriteLine("* Задание #5                                                                                            *");
        Console.WriteLine("* Вариант #2                                                                                            *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                                                  *");
        Console.WriteLine("* Дано значение температуры в градусах Фаренгейта.                                                      *");
        Console.WriteLine("* Определить значение этой же температуры в градусах Цельсия.                                           *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("Введите значение temp : ");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

        int res = Convert.ToInt32(ds.FahrenheitToСelsius(temp));
        Console.WriteLine(res);

        Console.ReadKey();
    }
}