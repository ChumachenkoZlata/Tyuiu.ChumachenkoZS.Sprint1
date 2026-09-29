using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChumachenkoZS.Sprint1.Task7.V3.Lib
{
    public class DataService : ISprint1Task7V3
    {
        public double Calculate(double x, double y)
        {
            double ch = 3 + Math.Exp(y - 1);
            double zn = 1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x));
            double result = ch / zn;
            return Math.Round(result, 3);
        }
    }
}
