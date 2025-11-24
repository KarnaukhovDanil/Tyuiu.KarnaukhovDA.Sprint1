using tyuiu.cources.programming.interfaces.Sprint1;
//            2
//     -x   5x         2
//z = 2   + ---  - cosx    + sin(2xy)
//            3
//          3x
namespace Tyuiu.KarnaukhovDA.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task7V14
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow(2, -x) + 5 * Math.Pow(x, 2) / 3 * Math.Pow(x, 3) - Math.Pow(Math.Cos(x), 2) + Math.Sin(2 * x * y);
            return res;
        }
    }
}
