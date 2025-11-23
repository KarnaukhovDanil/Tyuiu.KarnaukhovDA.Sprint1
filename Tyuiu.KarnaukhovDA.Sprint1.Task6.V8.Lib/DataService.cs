using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KarnaukhovDA.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            value = value.Replace("Привет", "риветП");
            value = value.Replace("Мир", "ирМ");
            

            return value;
        }
    }
}
