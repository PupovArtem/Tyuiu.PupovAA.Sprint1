using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PupovAA.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            double z = (Math.Sin(Math.Abs(x)) + ((Math.Cos(Math.Pow(x, 2))) / (3 * Math.Pow(x, 3))) - (Math.Sin(Math.Sqrt((Math.Pow(x, 2)) - 1))));
            return Math.Round(z, 3);
        }
    }
}
