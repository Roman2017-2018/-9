using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public struct Student:IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Student student = (Student)obj;
            if (this.Age > student.Age) return 2;
            if (this.Age < student.Age) return -2;
            return 0;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() {Age = 22,Name = "Василий"};
            Student student2 = new Student() { Age = 19, Name = "Наталья" };
            Student student3 = new Student() { Age = 23, Name = "Василий" };
            Student student4 = new Student() { Age = 12, Name = "Василий" };
            Student student5 = new Student() { Age = 26, Name = "Василий" };
            Student[] students = new Student[]{ student1, student2 , student3 };
            Array.Sort(students);
        }
    }
}
