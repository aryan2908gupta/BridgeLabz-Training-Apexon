using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegates
{
   public class Predacte
    {
      public  static bool isValidAge(int age)
        {
            if (age < 18)
            {
                return false;
            }
            return true;

        }
    }
}
