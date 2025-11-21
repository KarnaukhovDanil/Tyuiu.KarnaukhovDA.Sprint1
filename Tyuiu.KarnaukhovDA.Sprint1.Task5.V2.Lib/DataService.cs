using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KarnaukhovDA.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double res = (temp - 32) * Math.Pow(5, 1) / Math.Pow(9, 1);
            return (int)res;
        }
    }
}
