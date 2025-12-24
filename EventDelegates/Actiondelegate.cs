using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegates
{
    internal class Actiondelegate
    {
        static void sendEmail(string msg)
        {
            Console.WriteLine($"Email : {msg}");
        }
        static void sendSms(string msg) {
            Console.WriteLine($"SMS : {msg}");
        }
    }
}
