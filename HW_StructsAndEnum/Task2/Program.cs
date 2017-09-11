using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    class Program
    {
/*
 2.	Для получения места в общежитии формируется список студентов, который включает Ф.И.О. cтудента, 
 группу, средний балл, доход на члена семьи, пол (перечисление), форма обучения(перечисление).
 Общежитие в первую очередь предоставляется тем, 
 у кого доход на члена семьи меньше двух минимальных зарплат, затем остальным 
 в порядке уменьшения среднего балла. Вывести список очередности предоставления мест в общежитии.
*/
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            StudentHostel studentHostel = new StudentHostel();
            int count = 0;
            int menu = -1;
            for (;;)
            {
                Clear();
                WriteLine("1 - Добавить студента");
                WriteLine("2 - Список студентов");
                WriteLine("3 - Очередь на общежитие");
                WriteLine("0 - Выход");
                menu = Convert.ToInt32(ReadLine());
                if (menu == 1)
                {
                    Clear();
                    students.Add(new Student());
                    students[count++].Input();
                    Clear();
                    menu = -1;
                }
                else if (menu == 2)
                {
                    Clear();
                    WriteLine("Список студентов:");
                    foreach (var i in students)
                    {
                        WriteLine();
                        i.Print();
                    }
                    WriteLine("\nНажмите Enter для возврата в меню...");
                    ReadLine();
                    Clear();
                    menu = -1;
                }
                else if (menu == 3)
                {
                    Clear();
                    Write("Введите мин. зарплату: ");
                    int salary = Convert.ToInt32(ReadLine());
                    studentHostel.QueueInHostel(students, salary);
                    foreach(var i in studentHostel.queueInHostel)
                    {
                        i.Print();
                        WriteLine();
                    }
                    WriteLine("\nНажмите Enter для возврата в меню...");
                    ReadLine();
                    Clear();
                    menu = -1;
                }
                else if (menu == 0) break;
            }
        }
    }
}
