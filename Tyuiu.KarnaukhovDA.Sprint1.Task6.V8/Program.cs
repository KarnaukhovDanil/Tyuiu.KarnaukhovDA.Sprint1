using Tyuiu.KarnaukhovDA.Sprint1.Task6.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                             *");
        Console.WriteLine("* Тема: Работа со строками класса String                                                                *");
        Console.WriteLine("* Задание #6                                                                                            *");
        Console.WriteLine("* Вариант #8                                                                                            *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("* Написать программу: пользователь вводит текст.                                                        *");
        Console.WriteLine("* Напечатать все слова, перенеся их первую букву в конец.                                               *");
        Console.WriteLine("*                                                                                                       *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine("Введите строку :");
        string str = Console.ReadLine();

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

        Console.WriteLine(ds.MoveLetterToEnd(str));

        Console.ReadKey();
    }
}