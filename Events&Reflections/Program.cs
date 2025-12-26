using System.Reflection;

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

            // Reflection
            Console.WriteLine("--------------------------------------");
            Reflection rs = new Reflection();
            rs.reflcode();

            Console.WriteLine("-------------------------------------------------------------");

            // Declare Instance of class Assembly
            // Call the GetExecutingAssembly method
            // to load the current assembly
            Assembly executing = Assembly.GetExecutingAssembly();

            // Array to store types of the assembly
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                // Display each type
                Console.WriteLine("Class : {0}", item.Name);

                // Array to store methods
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method
                    Console.WriteLine("--> Method : {0}", method.Name);

                    // Array to store parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        // Display each parameter
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }
        }
    }
}