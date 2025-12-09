using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.DataTypes
{
    internal class BasicDataType
    {
        public void print()
        {
            String textage = "23";
            int age = Convert.ToInt32(textage);
            Console.WriteLine(age);

            String doublenum = "234352";
          //  double num = 234567D;

              double num = Convert.ToDouble(textage);
            Console.WriteLine(num);

            String textnum1 = "23.5";
            float num1 = Convert.ToSingle(textage);
           // float num1 = 23.5F;
            Console.WriteLine(num1);

            double num2 = 345.6;
            Console.WriteLine(num2);

            String textmoney = "2034.56";

            decimal money = Convert.ToDecimal(textmoney);
            Console.WriteLine(money);

            String s = "Aryan";
           Console.WriteLine(s);

            char letter = 'A';
            Console.WriteLine(letter);     
            
            bool value = false;
            bool isMale = true;


        }
    }
}
