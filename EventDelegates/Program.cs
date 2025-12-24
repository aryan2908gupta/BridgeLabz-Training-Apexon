namespace EventDelegates
{
    public delegate void Notify(string message);
    internal class Program
    {
        static void sendEmail(string msg)
        {
            Console.WriteLine($"Email : {msg}");
        }

        static void sendSms(string msg) {
            Console.WriteLine($"SMS : {msg}");
        }
        static void Main(string[] args)
        {
            /*
            Notify notify;
            notify = sendEmail;
            notify += sendSms; // Multicast Delegate

            notify("Order Placed");
            */

            /*
            
            Action<string> notify = sendEmail;
            notify += sendSms;
            notify("Order Placed");
            */

            /*
            Predicate<int> isEven = num => num % 2 == 0;
            Console.WriteLine(isEven(10));
            Console.WriteLine("---------------------------------------");        
            
            Predicate<int> checkingage = Predacte.isValidAge;

            Console.WriteLine(checkingage(20)); // true
            Console.WriteLine(checkingage(15)); // false
            */

            Func<int, int, int> addNum = (a, b) => a + b;
            Console.WriteLine(addNum(10,20));

            Func<string> greeting = Func.greet;
            Console.WriteLine(greeting());

        }
    }
}
