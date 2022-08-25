using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Xml.Linq;

namespace WorkLis4
{
    struct NoteBook
    {
        public NoteStruct Getter() //Получаем данные у пользователя и возвращаем экземпляр NoteStruct
        {
            WriteLine("Введите ФИО:");
            string? fio = ReadLine();  
            WriteLine("Введите улицу:");
            string? street = ReadLine();
            WriteLine("Введите номер дома:");
            short HouseNum = Convert.ToInt16(ReadLine());
            WriteLine("Введите номер квартиры:");
            short CellNum = Convert.ToInt16(ReadLine());
            WriteLine("Введите мобильный телефон:");
            string? MPhone = ReadLine();
            WriteLine("Введите домашний телефон:");
            string? HPhone = ReadLine();

            NoteStruct Note = new NoteStruct(fio, street, HouseNum, CellNum, MPhone, HPhone);

            return Note;
        }

        public void Writter(NoteStruct note) // Поллучаем экземпляр NoteStruct. Генерируем структуру. Сохраняем данные в файл.
        {
            XElement person = new XElement("Person");
            XElement address = new XElement("Address");
            XElement street = new XElement("Street");
            XElement housenum = new XElement("HouseNumber");
            XElement cellnum = new XElement("FlatNumber");
            XElement phones = new XElement("Phones");
            XElement mphones = new XElement("MobilePhone");
            XElement hphones = new XElement("FlatPhone");

            XAttribute name = new XAttribute("Name", note.FIO);

            person.Add(address, phones, name);
            address.Add(street, housenum, cellnum);
            phones.Add(mphones, hphones);
            hphones.Add(note.HousePhone);
            mphones.Add(note.MobilePhone);
            cellnum.Add(note.CellNum);
            housenum.Add(note.HouseNum);
            street.Add(note.Street);

            person.Save("_NoteInBook.xml");


        }

    }
}
