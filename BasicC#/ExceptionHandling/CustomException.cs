using System;

namespace BasicC_.ExceptionHandling
{
    internal class CustomException
    {
        public void error()
        {
            int a = 10;
            int b = 0;

            try
            {
                if (b == 0)
                {
                    // throw new ZeroExp();
                    throw new ZeroExp("Pagal hain kyaa cant divide by zero...");
                }

                int x = a / b;
                Console.WriteLine(x);
            }
            catch (ZeroExp z)
            {
                Console.WriteLine($"Msg is : {z.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
