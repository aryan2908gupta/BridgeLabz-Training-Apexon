using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class UsernameAndPassword
    {
        public void getCredentials()
        {
            int attempt = 0;
            int maxattempt = 3;

            String correctUser = "aryan";
            String correctPassword = "123";

            while (attempt < maxattempt)
            {
                Console.Write("Enter the username : ");
                String? user = Console.ReadLine();

                Console.WriteLine();
                Console.Write("Enter the password : ");
                String? password = Console.ReadLine();

                if(user == null || password == null)
                {
                    Console.WriteLine("Please enter valid information");
                }

                if(user != correctUser)
                {
                    Console.WriteLine("Incorrect user");
                    attempt++;
                    continue;

                }

                if (password != correctPassword)
                {
                    Console.WriteLine("Incorrect password");
                    attempt++;
                    continue;

                }

                if (user == correctUser && password == correctPassword)
                {
                    Console.WriteLine("Login Successful");
                    break;  // exit the while loop
                }

            }
            if (attempt == 3)
            {
                Console.WriteLine("\nAccount locked due to too many failed login attempts.");
            }
        }
    }
}
