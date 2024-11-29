using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChashkovTA.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool isInRegion = IsPointInRegion(x, y);

            return isInRegion;
        }

        static bool IsPointInRegion(double x, double y)
        {
            if (x < 0 || x > 1 || y < 0 || y > 1) return false; // быстрая проверка на границы области


            return (y >= Math.Pow(x, 2)) && (y <= Math.Exp(x)) && (y <= Math.Exp(-x));

        }
    }
}
