using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Reflections
{
    internal class StudentReflectionAssemblies
    {
        public int RollNo
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        // No Argument Constructor
        public StudentReflectionAssemblies()
        {
            RollNo = 0;
            Name = string.Empty;
        }

        // Parameterised Constructor
        public StudentReflectionAssemblies(int rno, string n)
        {
            RollNo = rno;
            Name = n;
        }

        // Method to Display Student Data
        public void displayData()
        {
            Console.WriteLine("Roll Number : {0}", RollNo);
            Console.WriteLine("Name : {0}", Name);
        }
    }
}
