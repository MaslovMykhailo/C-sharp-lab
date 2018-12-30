using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Person
    {
        public int BirthdayYear
        {
            get => Birthday.Year;
            set => Birthday = new DateTime(value, Birthday.Month, Birthday.Day);
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

        public Person()
        {
            Name = Surname = "Не опредено";
            Birthday = new DateTime();
        }
        public Person(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public virtual void PrintFullInfo()
        {
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Дата рождения: " + Birthday.ToShortDateString());
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person p = (Person)obj;
                return (Name == p.Name) && (Surname == p.Surname) && System.DateTime.Equals(Birthday, p.Birthday);
            }
        }
    }
}
