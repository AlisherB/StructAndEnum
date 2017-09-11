using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    public class Student
    {
        int menu1;
        int menu2;
        public string FullName { get; set; }
        public string Group { get; set; }
        public int AverageScore { get; set; }
        public int SalaryOnFamily { get; set; }
        public Sex Sex{ get; set; }
        public FormOfEducation Education { get; set; }
        public void Input()
        {
            WriteLine("Добавление студента\n");
            Write("Введите ФИО: ");
            FullName = ReadLine();
            Write("Введите группу: ");
            Group = ReadLine();
            Write("Средний балл: ");
            AverageScore = Int32.Parse(ReadLine());
            Write("Доход(тг): ");
            SalaryOnFamily = Int32.Parse(ReadLine());
            WriteLine("Пол:\n\t1 - мужской\t2 - женский");
            
            for (;;)
            {
                if (!Int32.TryParse(ReadLine(), out menu1))
                {
                    continue;
                }
                if (menu1 == 1)
                {
                    Sex = Sex.Male;
                    break;
                }
                else if (menu1 == 2)
                {
                    Sex = Sex.Female;
                    break;
                }
            }
            WriteLine("Форма обучения:\n\t1 - очное\t2 - заочное");
            for (; ;)
            {
                if (!Int32.TryParse(ReadLine(), out menu2))
                {
                    continue;
                }
                if (menu2 == 1)
                {
                    Education = FormOfEducation.FullTime;
                    break;
                }
                else if (menu2 == 2)
                {
                    Education = FormOfEducation.Distance;
                    break;
                }
            }
        }
        public void Print()
        {
            WriteLine("ФИО: " + FullName);
            WriteLine("Группа: " + Group);
            WriteLine("Средний балл: " + AverageScore);
            WriteLine("Доход: " + SalaryOnFamily);
            if (Sex == Sex.Male)
                WriteLine("Пол: мужской");
            else
                WriteLine("Пол: женский");

            if (Education == FormOfEducation.FullTime)
                WriteLine("Форма обучения: очная");
            else
                WriteLine("Форма обучения: заочная");
        }
    }
}
