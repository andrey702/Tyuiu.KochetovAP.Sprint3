using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            StringBuilder numbers = new StringBuilder();

            // Используем цикл foreach для перебора всех символов
            foreach (char c in value)
            {
                // Оставляем только цифры, удаляем буквы и знаки препинания
                if (char.IsDigit(c))
                {
                    numbers.Append(c);
                }
            }

            // Если цифры найдены, преобразуем в число
            if (numbers.Length > 0)
            {
                return int.Parse(numbers.ToString());
            }

            // Если цифр не найдено, возвращаем 0 или можно выбросить исключение
            return 0;


        }
 
            

           
        
    }
}
