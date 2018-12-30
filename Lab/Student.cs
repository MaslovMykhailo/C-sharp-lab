using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    enum Education
    {
        Master,
        Bachelor,
        SecondEducation,
        PhD
    }

    class Student : Person, ICloneable
    {
        private Examination[] PassedExams;
        public double GragePointAvarage
        {
            get
            {
                int count = PassedExams.Length;
                int rating = 0;
                for (int i = 0; i < count; i++)
                {
                    rating += PassedExams[i].Rating;
                }

                return rating/count;
            }
        } 

        public string Group { get; set; }
        public string RecordBookNumber { get; set; }
        internal Education Qualification { get; set; }

        public void AddExams(Examination[] examsList)
        {
            Examination[] newList = new Examination[PassedExams.Length + examsList.Length];
            PassedExams.CopyTo(newList, 0);
            examsList.CopyTo(newList, PassedExams.Length);
            PassedExams = newList;
        }

        public override string ToString()
        {
            return Name + " - " + Surname + " - " + Group;
        }

        public Student(
            string name, string surname, DateTime birthday,
            Education qualification, string group, string recordBookNumber,
            Examination[] exams
            )
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Qualification = qualification;
            Group = group;
            RecordBookNumber = recordBookNumber;
            PassedExams = exams;
        }

        public override void PrintFullInfo()
        {
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Дата рождения: " + Birthday.ToShortDateString());
            Console.WriteLine("Квалификация: " + Qualification);
            Console.WriteLine("Группа: " + Group);
            Console.WriteLine("Номер зачетки: " + RecordBookNumber);
            Console.WriteLine("Екзамены: ");
            for (int i = 0; i < PassedExams.Length; i++)
            {
                Console.WriteLine(PassedExams[i].ToString());
            }
        }

        public object Clone()
        {
            Examination[] Exams = new Examination[PassedExams.Length];
            PassedExams.CopyTo(Exams, 0);
            return new Student(Name, Surname, Birthday, Qualification, Group, RecordBookNumber, Exams);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < PassedExams.Length; i++)
            {
                if (PassedExams[i].Type == "зачет")
                {
                    yield return PassedExams[i];
                }
                else continue;
            }
        }

        public Examination[] GetExamList()
        {
            Examination[] ExamList = new Examination[PassedExams.Length];
            PassedExams.CopyTo(ExamList, 0);
            Array.Sort(ExamList);
            return ExamList;
        }
    }
}
