using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChashkovTA.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            if (k < 1 || k > 365)
            {
                return "Некорректное значение k. Оно должно быть в диапазоне от 1 до 365.";
            }

            // Вычисляем день недели с помощью оператора switch.
            // Остаток от деления на 7 дает нам номер дня недели (0 - понедельник, 1 - вторник, ..., 6 - воскресенье)
            int dayOfWeek = (k - 1) % 7;

            string dayName;
            switch (dayOfWeek)
            {
                case 0:
                    dayName = "Понедельник";
                    break;
                case 1:
                    dayName = "Вторник";
                    break;
                case 2:
                    dayName = "Среда";
                    break;
                case 3:
                    dayName = "Четверг";
                    break;
                case 4:
                    dayName = "Пятница";
                    break;
                case 5:
                    dayName = "Суббота";
                    break;
                case 6:
                    dayName = "Воскресенье";
                    break;
                default:
                    dayName = "Ошибка"; // Должно быть недостижимым, но добавляем для полноты
                    break;
            }

            return dayName;
        }

       
    }
}
