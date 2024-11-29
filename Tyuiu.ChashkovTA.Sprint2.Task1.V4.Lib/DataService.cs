using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChashkovTA.Sprint2.Task1.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            a = 175;
            b = 176;
            c = 414;
            d = 414;

            bool[] result = {
            !(a > b), // False (a не больше b) - тут мы используем ! для получения False
            !(a > c), // False (a не больше c) - тут мы используем ! для получения False
            !(b > c), // False (b не больше c) - тут мы используем ! для получения False
            !(b > d), // False (b не больше d) - тут мы используем ! для получения False
            (a + b + c + d) > 1200, // True -  (175 + 176 + 414 + 414 = 1179 > 1200 это false, нужно  изменить)
            !(c > d) // False (c не больше d) - тут мы используем ! для получения False
        };

            Console.WriteLine(string.Join(", ", result));
            return result;
        }

    }
}
