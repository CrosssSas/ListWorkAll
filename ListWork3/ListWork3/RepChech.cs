using static System.Console;

namespace ListWork3
{
    struct RepChech
    {
        public HashSet<int> NumAdder() // Проверяет повторы и добавляет число в множество
        {
            HashSet<int> result = new HashSet<int>();
            bool trigger = true;

            while (trigger)
            {
                WriteLine("Введите число:");
                int number = Convert.ToInt32(ReadLine());

                if (result.Contains(number))
                {
                    WriteLine("Данный элемент уже был добавлен.");
                }
                else
                {
                    result.Add(number);
                }

                WriteLine();
                WriteLine("Добавить ещё число?\n1 - Да\nНажмите Enter - Нет");
                string? chose = ReadLine();
                if (chose == "")
                {
                    trigger = false;
                }
            }

            return result;
        }
    }
}
