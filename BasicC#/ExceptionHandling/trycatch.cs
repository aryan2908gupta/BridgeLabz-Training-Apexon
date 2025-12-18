using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.ExceptionHandling
{
    internal class trycatch
    {
        public void error()
        {
            int a = 10;
            int b = 0;

            try
            {
               int x = a/b;
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Arithmetic error occurred: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finallt block executed");
                
            }
        }
    }
}