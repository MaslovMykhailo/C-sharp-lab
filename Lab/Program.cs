using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Демонстрация основной части задания
            Student student = new Student(
                "Михаил", "Маслов", new DateTime(2000, 3, 18),
                Education.Bachelor, "ИП-71", "ip7116",
                new Examination[] {new Examination(3, "ООП", "Муха И.П.", 90, "экзамен", new DateTime(2019, 1, 9))}
            );

            Console.WriteLine(student.ToString());
            Console.WriteLine("------------------------------------");

            student.AddExams(new Examination[] 
            {
                new Examination(3, "Философия", "Куцик Е.М.", 82, "зачет", new DateTime(2018, 12, 27)),
                new Examination(3, "Теория вероятностей", "Гарко И.И.", 95, "экзамен", new DateTime(2019, 1, 14)),
                new Examination(3, "ОКР", "Очеретный А.К.", 100, "зачет", new DateTime(2018, 12, 22))
            }
            );
            student.PrintFullInfo();
            Console.WriteLine("------------------------------------");

            // Демонстрация задания 1
            Student copyStudent = (Student)student.Clone();
            copyStudent.PrintFullInfo();

            // Демонстрация задания 2
            Person person1 = new Person("Георгий", "Голополосов", new DateTime(1999, 12, 21));
            Person person2 = new Person("Георгий", "Голополосов", new DateTime(1999, 12, 21));

            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine("------------------------------------");

            // Демонстрация задания 9
            foreach (Examination exam in student)
            {
                Console.WriteLine(exam.ToString());
            }
            Console.WriteLine("------------------------------------");

            // Демонстрация задания 12
            Examination[] exams = student.GetExamList();
            for (int i = 0; i < exams.Length; i++)
            {
                Console.WriteLine(exams[i].ToString());
            }
        }
    }
}
