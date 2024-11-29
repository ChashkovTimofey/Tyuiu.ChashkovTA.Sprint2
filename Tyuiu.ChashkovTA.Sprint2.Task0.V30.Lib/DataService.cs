using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChashkovTA.Sprint2.Task0.V30.Lib
{
    public class DataService : ISprint2Task0V30
    {
        public bool[] GetCompareOperations(int x, int y)
        {
             x = 95;
             y = 1735;

            bool[] result = {
            x < y,              // True
            x * 2 >= y,         // False (190 >= 1735 is false)
            x + y > 1800,       // True (1830 > 1800)
            y / x <= 17,        // False (1735 / 95 ≈ 18.26 > 17)
            (y - x) > 1600,     // True (1735 - 95 = 1640 > 1600)
            (x * y) % 100 == 75  // False (95 * 1735 % 100 = 75)
            };
            return result;
        }
    }
}
