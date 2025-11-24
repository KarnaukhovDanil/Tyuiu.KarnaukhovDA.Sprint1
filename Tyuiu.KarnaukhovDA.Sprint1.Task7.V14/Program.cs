using Tyuiu.KarnaukhovDA.Sprint1.Task7.V14.Lib;
//            2
//     -x   5x         2
//z = 2   + --  - cosx    + sin(2xy)
//            3
//          3x
internal class Program
{
    

    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Карнаухов Д. А. | СМАРТб-25-1";
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                                             *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                               *");
        Console.WriteLine("* Задание #7                                                                                            *");
        Console.WriteLine("* Вариант #14                                                                                           *");
        Console.WriteLine("* Выполнил: Карнаухов Даниил Александрович | СМАРТб-25-1                                                *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                              *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение                                        *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                                                 *");
        Console.WriteLine("*                                                                                                       *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                      *");
        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("            2                                                                                            ");
        Console.WriteLine("     -x   5x         2                                                                                   ");
        Console.WriteLine("z = 2   + --   - cosx  +  sin(2xy)                                                                       ");
        Console.WriteLine("             3                                                                                           ");
        Console.WriteLine("          3x                                                                                             ");

        double x, y;
        Console.WriteLine("Введите значение X =");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение Y =");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("*********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                            *");
        Console.WriteLine("*********************************************************************************************************");

 
        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadKey();
    }
}