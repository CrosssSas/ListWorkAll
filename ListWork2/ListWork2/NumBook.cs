using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ListWork2
{
    struct NumBook
    {
        public Dictionary<string,string> DataAdd() //Добавляет данные в словарь
        {
            bool trigger = true;

            Dictionary<string, string> dic = new Dictionary<string, string>();
            while (trigger)
            {
                WriteLine("Введите номер телефона:");
                string? number = ReadLine();
                WriteLine("Введите ФИО владельца:");
                string? fio = ReadLine();
                
                if (number != null && fio != null)
                    dic.Add(number, fio);

                WriteLine("Добавить ещё номер?\n1 - Да\nНажмите Enter - Нет");
                string? chose = ReadLine();
                if (chose == "")
                {
                    trigger = false;
                }
            }
             
            return dic;
        }

        public void Searcher(Dictionary<string, string> dict) //Поиск по номеру телефона
        {
            bool trigger = true;

            while (trigger)
            {
                WriteLine("Поиск");
                WriteLine("Введите номер телефона:");
                string? key = ReadLine();
                string? value;
                if (key != null)
                    if (dict.TryGetValue(key, out value))
                    {
                        WriteLine($"{value} является владельцем {key}");
                    }
                    else
                    {
                        WriteLine("Номер не найден или введён неправильно");
                    }

                WriteLine("Повторить поиск?\n(1 - Да\nНажмите Enter - Нет");
                string? chose = ReadLine();
                if (chose == "")
                {
                    trigger = false;
                }
            }
        }

    }
}
