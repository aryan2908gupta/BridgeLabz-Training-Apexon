using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Constructor
{
    internal class parameterized
    {
        int age;
        string name;
        string description;

        //public parameterized(int age, string name, string description)
        //{
        //    this.age = age;
        //    this.name = name;
        //    this.description = description;
        //}

        // Now making  private constructor 

        private parameterized(int age, string name, string description)
        {
            this.age = age;
            this.name = name;
            this.description = description;
        }

        /*
         * It is a public method (so anyone can call it)

It is static (so you don’t need an object to call it)

It creates an object using the private constructor

It returns that object
         */

        public static parameterized Create(int age, string name, string description)
        {
            return new parameterized(age, name, description);
        }


        public void Display()
        {
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Description: " + description);
        }
    }
}
