using static System.Console;

namespace ListWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            RepChech rep = new RepChech();
            bool trigger = true;
            HashSet<int> set = new HashSet<int>();

            while (trigger)
            {
                WriteLine();
                WriteLine("1 - Добавить число\n2 - Вывести множество на экран\n0 - Выход");
                string? ProtoChose = ReadLine();
                if (ProtoChose == "1")
                {
                    set = rep.NumAdder();
                }
                else if(ProtoChose == "2")
                {
                    WriteLine();
                    WriteLine("Множестно:");
                    foreach (int i in set) { Write($"{i}  "); }
                    WriteLine();
                }

                WriteLine();
                WriteLine("Нужно сделать что-то ещё?\n1 - Да\nНажмите Enter - Нет");
                string? chose = ReadLine();
                if (chose == "")
                {
                    trigger = false;
                }
            }
        }
    }
}
