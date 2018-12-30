using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Examination : IComparable<Examination>
    {
        public Examination()
        {
            Semester = Rating = 0;
            Subject = Examinator = Type = "Не определено";
            Date = new DateTime();
        }

        public Examination(int semester, string subject, string examinator, int rating, string type, DateTime date)
        {
            Semester = semester;
            Subject = subject;
            Examinator = examinator;
            Rating = rating;
            Type = type;
            Date = date;
        }

        public int Semester { get; set; }
        public string Subject { get; set; }
        public string Examinator { get; set; }
        public int Rating { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return Subject + " - " + Examinator + " - " + Rating;
        }

        public int CompareTo(Examination exam)
        {
            return Subject.CompareTo(exam.Subject);
        }
    }
}
