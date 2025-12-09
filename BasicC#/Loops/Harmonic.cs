using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace BasicC_.Loops
{
    internal class Harmonic
    {
        public void harmonic()
        {
            Console.Write("Enter the number : ");
            int x = int.Parse(Console.ReadLine());

            double harmonic = 0.0;

            for(int i = 1; i <= x; i++)
            {
                harmonic = harmonic + 1.0 / i;
            }
            Console.WriteLine(harmonic);

        }
    }
}
