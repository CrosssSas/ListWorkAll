using System;
using static System.Console;

namespace WorkLis4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NoteBook notebook = new NoteBook(); //Инициализация структуры

            
            NoteStruct note = notebook.Getter(); //Получаю запись


            notebook.Writter(note); //Передаю полученную запись в метод XML-ирования данных

        }
    }
}