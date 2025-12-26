namespace NunitCal
{
   public class Program
    {
        static void Main(string[] args)
        {
          Calculator cal = new Calculator();
            Console.WriteLine("Enter Marks : ");
            int grade = int.Parse(Console.ReadLine());  
           string res =  cal.GetGradeByPercentage(grade);
            Console.WriteLine(res);
        }
    }
}
