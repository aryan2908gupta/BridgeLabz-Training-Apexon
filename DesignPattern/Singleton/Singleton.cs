using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    internal class Singleton
    {
        // Step 1: static variable to hold single object
        private static Singleton instance;

        // Step 2: private constructor (no one can use new)
        private Singleton()
        {
            Console.WriteLine("Singleton object created");
        }

        // Step 3: public method to get the object
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello from Singleton");
        }
    }
}
