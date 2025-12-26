namespace Events_Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            Person person = new Person();
            Person1 person1 = new Person1();

            alarm.AlarmRang += person.WakeUp;
            alarm.AlarmRang += person1.wakeupSid;

            // Trigger
            alarm.Ring();

            Result result = new Result();
            Student student = new Student();

            // subscribe
            result.ResultDeclared += student.OnResultDeclared;

            // trigger
            result.Declare(85);
        }
    }
}
