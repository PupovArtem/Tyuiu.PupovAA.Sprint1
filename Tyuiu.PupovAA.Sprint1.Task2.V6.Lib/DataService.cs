using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PupovAA.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            double r = (value / 1000.0);
            return Math.Round( r ,3);
        }
    }
}
