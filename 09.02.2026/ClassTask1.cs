using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_семестр_финал
{
    public class ClassTask1
    {
        public struct Student
            //сократить:
           // public string Surname => _surname;
        {
            //поля
            private string _surname;
            private int _age;
            private int[] _marks;
            private int _debth;

            //св-ва
            public string Surname
            {
                get
                {
                    return _surname;
                }
            }
            public int Age
            {
                get
                {
                    return _age;
                }
            }
            public double AverageMark
            {
                get
                {
                    if (_marks == null || _marks.Length == 0)
                    {
                        return 0;
                        
                    }
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
            public Student(string surname, int age)
            {
                //проицианилизировать ВСЕ поля
                _surname = surname;
                _age = age;
                _marks = new int[0];
                _debth = 0;
            }

        }
        //КОНСТРУКТОР совпадает с название структуры
        
}
