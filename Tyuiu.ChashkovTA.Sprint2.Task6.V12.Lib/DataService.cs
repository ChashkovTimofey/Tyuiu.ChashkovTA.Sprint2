using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChashkovTA.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevDay = g - 1;
            int prevMonth = m;
            int prevYear = n;

            if (prevDay == 0)
            {
                prevMonth--;
                if (prevMonth == 0)
                {
                    prevMonth = 12;
                    prevYear--;
                }
                prevDay = GetDaysInMonth(prevMonth, IsLeapYear(prevYear));
            }

            return $"{prevDay}.{prevMonth}.{prevYear}";
        }

        // Функция для определения количества дней в месяце с помощью паттерн-матчинга
        static int GetDaysInMonth(int month, bool isLeapYear) => month switch
        {
            2 => isLeapYear ? 29 : 28,
            4 or 6 or 9 or 11 => 30,
            _ => 31
        };


        // Функция определения високосного года
        static bool IsLeapYear(int year) => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

    }
    
}
