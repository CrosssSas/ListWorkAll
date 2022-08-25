using System;
using static System.Console;

namespace ListWork // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Functional fun = new Functional();

            List<sbyte> list1 = fun.Generation();

            WriteLine("Изначальная коллекция:");
            
            fun.Print(list1);

            fun.Remover(list1);
            
            WriteLine();
            WriteLine("Коллекция после сортировки:");
            fun.Print(list1);
            
        }
    }
}