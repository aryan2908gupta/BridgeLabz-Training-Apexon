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
            Notify notify;
            notify = sendEmail;
            notify += sendSms; // Multicast Delegate

            notify("Order Placed");
            
        }
    }
}
