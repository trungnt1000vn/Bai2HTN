using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
   class Person
    {
        protected string name;

        public string Name { get => name; set => name = value; }
    }
    class Student : Person
    {
        private int classnumber;

        public Student()
        {
        }

        public int Classnumber { get => classnumber; set => classnumber = value; }
        public Student(string name,int classnumber)
        {
            this.name = name;
            Classnumber = classnumber;
        }
    }
    class Teacher : Person
    {
        public Teacher()
        {
        }
        public Teacher(string name)
        {
            this.name = name;
        }
    }
    class Disciplines
    {
        private string name;
        private int lectures;
        private int exercises;

        public Disciplines()
        {
        }

        public string Name { get => name; set => name = value; }
        public int Lectures { get => lectures; set => lectures = value; }
        public int Exercises { get => exercises; set => exercises = value; }

    }
    class Class
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Disciplines> disciplines = new List<Disciplines>();
        Class()
        {

        }

    }
}
