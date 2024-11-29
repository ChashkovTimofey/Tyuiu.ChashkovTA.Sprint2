using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChashkovTA.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool[,] area = {
            {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
            {false, false, false, true, true, true, false, false, false, true, true, false, false, false, false},
            {false, false, false, true, true, true, false, false, false, true, true, false, false, false, false},
            {false, false, false, true, true, true, true, true, true, true, true, true, false, false, false},
            {false, false, false, true, true, true, true, true, true, true, true, true, false, false, false},
            {false, false, false, true, true, true, true, true, true, true, true, true, false, false, false},
            {false, false, false, true, true, true, true, true, true, true, true, true, false, false, false},
            {false, false, false, true, true, true, true, true, true, true, true, true, false, false, false},
            {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, true, true, true, true, true, true, false, false, false},
            {false, false, false, false, false, false, true, true, true, true, true, true, false, false, false},
            {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false},
            {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false}
        };



            
            if (area[y - 1, x - 1]) 
            {
                return true;
            }
            else
            {
               return false;
            }
            }
    }
}
