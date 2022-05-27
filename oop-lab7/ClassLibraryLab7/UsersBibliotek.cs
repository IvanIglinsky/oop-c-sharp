using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab7
{
    public class UsersBibliotek : People
    {
        protected double NumberReadTicket { get; set; }
        protected string DateTake { get; set; }
        protected double CostMonthRead { get; set; }
        public UsersBibliotek(double numberReadTicket, string dateTake, double costMonthRead,string name,string surname,string date)
        {
            NumberReadTicket = numberReadTicket;
            DateTake = dateTake;
            CostMonthRead = costMonthRead;
            Name = name;
            Surname = surname;
            Date = date;
        }
        public UsersBibliotek()
        {
            NumberReadTicket = 10;
            DateTake="10.10.2010";
            CostMonthRead = 100;
            Name = "Andrey";
            Surname = "Pikyl";
            Date = "09.05.2004";

        }
        public UsersBibliotek(double numberReadTicket)
        {
            NumberReadTicket = numberReadTicket;
            DateTake = "01.01.2015";
            CostMonthRead = 60;
            Name = "Valeria";
            Surname = "Pochitaiko";
            Date = "10.03.1999";

        }
        public UsersBibliotek(UsersBibliotek obj)
        {
            NumberReadTicket = obj.NumberReadTicket;
            DateTake = obj.DateTake;
            CostMonthRead = obj.CostMonthRead;
            Surname = obj.Surname;
            Name = obj.Name;
            Date = obj.Date;
        }
        public void ShowInfo(UsersBibliotek usersBibliotek)
        {
            Console.WriteLine($"Ім'я:{usersBibliotek.Name}");
            Console.WriteLine($"Прізвище:{usersBibliotek.Surname}");
            Console.WriteLine($"Дата народження:{usersBibliotek.Date}");
            Console.WriteLine($"Номер читацького квитка:{usersBibliotek.NumberReadTicket}");
            Console.WriteLine($"Дата видачі:{usersBibliotek.DateTake}");
            Console.WriteLine($"розмір щомісячного читацького внеску:{usersBibliotek.CostMonthRead}");
        }
    }
}
