using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Student : Person
    {
        private int classnumber;

        public Student()
        {
        }

        public int Classnumber { get => classnumber; set => classnumber = value; }
        public Student(string name, int classnumber)
        {
            this.name = name;
            Classnumber = classnumber;
        }
    }
}
