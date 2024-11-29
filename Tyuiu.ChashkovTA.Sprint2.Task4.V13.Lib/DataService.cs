using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChashkovTA.Sprint2.Task4.V13.Lib
{
    public class DataService : ISprint2Task4V13
    {
        public double Calculate(double x, double y)
        {


            double z;

            if (Math.Sqrt(x * 3) > y * 2 - 20)
            {
                z = x + 10 * y;
            }
            else
            {
                z = 1 / x;
            }


            double expressionResult;

            if (y * y - Math.Pow(Math.Sin(y), 2) + 9 == 0)

            {
                expressionResult = (Math.Pow(x, 2) + Math.Pow(Math.Cos(y), 2) + 13) / (Math.Pow(y, 2) - Math.Pow(Math.Sin(y), 2) + 9);

                Console.WriteLine($"z = {Math.Round(z, 3)}, выражение: {Math.Round(expressionResult, 3)}");
            }
            return z; }
        }
    }