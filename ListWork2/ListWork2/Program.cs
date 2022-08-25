using System;
using static System.Console;

namespace ListWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumBook num = new NumBook(); //Инициализация структуры

            Dictionary<string, string> slovar = num.DataAdd(); //Вызов добавленения

            num.Searcher(slovar); //Вызов поиска
        }
    }
}
