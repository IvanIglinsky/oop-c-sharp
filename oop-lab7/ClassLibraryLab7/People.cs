namespace ClassLibraryLab7
{
    public class People
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string Date { get; set; }

        public People(string name, string surname, string date)
        {
            Name=name;
            Surname=surname;
            Date=date;
        }
        public People()
        {
            Name = "Ivan";
            Surname = "Ivanov";
            Date = "25.12.2003";
        }
        public People(string surname,string date)
        {
            Name = "Vovan";
            Surname=(surname);
            Date=date;
        }
        public People(People obj)
        {
            Name = obj.Name;
            Surname=obj.Surname;
            Date = obj.Date;
        }
        public void ShowInfo(People people)
        {
            Console.WriteLine($"Ім'я:{people.Name}");
            Console.WriteLine($"Прізвище:{people.Surname}");
            Console.WriteLine($"Дата народження:{people.Date}");

        }
    }
    

}