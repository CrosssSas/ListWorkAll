using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ListWork
{
    struct Functional
    {
        
        
        public List<sbyte> Generation() //Генерирует и сортирует по возрастанию List чисел
        {
            List<sbyte> listGen = new List<sbyte>();

            Random rand = new Random();

            for (int i = 0; i < 101; i++)
            {
                sbyte geNum = Convert.ToSByte(rand.Next(0, 101));
                listGen.Add(geNum);
            }

            listGen.Sort();

            return listGen;
        }

        public void Print(List<sbyte> list) //Выводит на экран различные List-ы и нумерует их
        {
            for (sbyte i = 0; i < list.Count; i++) WriteLine($"#{i} : {list[i]}");
        }

        public void Remover(List<sbyte> list) //Ищет и удаляет элементы больше 25 и меньше 50, а также выводит на экран удалённые элементы
        {
            sbyte CountFirst = 0; //Хранит индекс первого вхождение по условию 25 < i < 50
            sbyte CountCount = 0; //Хранит количество вхождений по условию 25 < i < 50

            List<sbyte> del = new List<sbyte>(); //Для удалённых элементов
            for (sbyte i = 0; i < list.Count; i++)
            {
                if (list[i] > 25 & list[i] < 50)
                {
                    if (CountCount == 0)
                    {
                        CountFirst = i;
                    }

                    del.Add(list[i]);
                    CountCount++;
                }
            }

            list.RemoveRange(CountFirst, CountCount);

            WriteLine();
            WriteLine("Удалённые элементы:");
            Print(del);
        }
    }
}
