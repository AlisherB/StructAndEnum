using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class StudentHostel
    {
        public List<Student> queueInHostel;
        List<Student> averageScore;
        public StudentHostel()
        {
            queueInHostel = new List<Student>();
            averageScore = new List<Student>();
        }
        public void QueueInHostel(List<Student> students, int salary)
        {
            foreach (var i in students)
            {
                if (i.SalaryOnFamily < salary * 2)
                {
                    queueInHostel.Add(i);
                }
                else if (!(i.SalaryOnFamily < salary * 2))
                {
                    averageScore.Add(i);
                }
            }
            foreach (var i in averageScore)
            {
                queueInHostel.Add(i);
            }
        }
    }
}
