using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Heriachaial_Inheritance
{
    internal class Animal
    {
        public void breathe()
        {
            Console.WriteLine("Animal is breathing");
        }

    }

    internal class  Dog : Animal
    {
        public void DogBreathe()
        {
            Console.WriteLine("Dog is breathing ...");
        }

    }

    internal class Cat : Animal
    {
        public void CatBreathe()
        {
            Console.WriteLine("Cat is breathing");
        }

    }
    
}
