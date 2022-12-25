using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Disciplines
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
}
