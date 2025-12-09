using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Loops
{
    internal class Perfect
    {
        public void Run() {
            int num = 28;
            int sum = 0;
            for (int i = 0; i <= num/2; i++) {
                if (num % i == 0)
                {
                    sum=sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not a Perfect Number");
            }
            }
    }
}
