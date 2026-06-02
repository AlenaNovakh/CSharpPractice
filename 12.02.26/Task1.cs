using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First10
{
    public class Task1
    {
        public struct Student
        {
            // Поля
            private string _surname;
            private int _age;
            private int[] _marks;
            private int _debth;
            private static int _count;

            // Свойства
            public static int Count => _count;
            public string Surname => _surname;
            public int Age => _age;
            public int[] Marks
            {
                get
                {
                    int[] copy = new int[_marks.Length];
                    for (int i = 0; i < copy.Length; i++)
                    {
                        copy[i] = _marks[i];
                    }
                    return copy;
                }
            }
            public double AverageMark
            {
                get
                {
                    if (_marks == null || _marks.Length == 0) return 0;

                    double average = 0;
                    for (int i = 0; i < _marks.Length; i++)
                    {
                        average += _marks[i];
                    }
                    average /= _marks.Length;
                    return average;
                }
            }
            public bool IsExpelled => _debth >= 10;

            // Конструктор
            static Student()
            {
                _count = 0;
            }
            public Student(string surname, int age)
            {
                // Проинициализировать ВСЕ поля
                _surname = surname;
                _age = age;
                _marks = new int[0];
                _debth = 100;
                _count++;
            }

            // Методы
            public static void Sort(Student[] students)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    for (int j = 0; j < students.Length; j++)
                    {
                        if (students[j - 1].Age > students[j].Age)
                        {
                            (students[j-1], students[j] ) = (students[j],  students[j-1]);
                        }
                    }
                }
            }
            public void Study(int mark)
            {
                if (_marks == null) return;
                if (mark < 2 || mark > 5) return;
                Array.Resize(ref _marks, _marks.Length + 1);
                _marks[^1] = mark;
            }
            public void Print()
            {
                Console.WriteLine(_surname);
                Console.WriteLine(_age);
                Console.WriteLine(string.Join(" ", _marks));
            }
            public struct Group
            {
                private string _name;
                private Student[] _students;

                public string Name => _name;
                public Student[] Students => _students; //копия не нужна

                public Group(string name)
                {
                    _name = name;
                    _students = new Student[0];
                }
            }
        }

    }
}
