using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLis4
{
    struct NoteStruct
    {
            
        public string FIO { get; set; } //ФИО

        public short HouseNum { get; set; } //Номер дома

        public short CellNum { get; set; } //Номер квартиры

        public string Street { get; set; } //Улица

        public string MobilePhone { get; set; } //Мобильный телефон

        public string HousePhone { get; set; } //Домашний телефон


        public NoteStruct(string FIO, string Street, short HouseNum, short CellNum, string MobilePhone, string HousePhone)
        {
           this.FIO = FIO;
           this.Street = Street;
           this.HouseNum = HouseNum;
           this.CellNum = CellNum;
           this.MobilePhone = MobilePhone;
           this.HousePhone = HousePhone;
        }

        
    }
}
