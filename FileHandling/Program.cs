using System.Runtime.InteropServices;
using System.Text.Json;
using System.Xml;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //   string path = @"C:\\Users\\aryan\\OneDrive\\Desktop\\Bridgelab\\BridgeLabz-Training-Apexon\\FileHandling\simple.txt";
            //   File.WriteAllText(path, "");
            //   Console.WriteLine("File created successfully.");
            //   // Writing the txt
            //   using (StreamWriter writer = new StreamWriter(path)) {
            //       writer.WriteLine("Line 1");
            //       writer.WriteLine("Line 2");
            //   }

            //   //Appending text
            //   File.AppendAllText(path, "\nThis is appended text");

            //   //Reading a File
            //   string content = File.ReadAllText(path);
            //   Console.WriteLine($"Content is :{ content}");

            //   //Reading a File Line By Line
            //   string[] lines = File.ReadAllLines(path);
            //   foreach (var line in lines)
            //   {
            //       Console.WriteLine(line);
            //   }

            //   using (StreamReader reader = new StreamReader(path)) {
            //       //string info  = reader.ReadToEnd();
            //       //  Console.WriteLine("File Content:");
            //       // Console.WriteLine(info);

            //       string line;
            //       while ((line = reader.ReadLine()) != null) {
            //           Console.WriteLine(line);
            //       }
            //   }

            //   // File Exists

            //   if (File.Exists(path)) {
            //       Console.WriteLine("Yes File Exits");
            //   }
            //   else
            //   {
            //       Console.WriteLine("File not found");
            //   }

            //   /*
            //    Delete A File
            //       File.Delete(path);
            //    */

            //   // Copying a File
            // string source =   @"C:\\Users\\aryan\\OneDrive\\Desktop\\Bridgelab\\BridgeLabz-Training-Apexon\\FileHandling\source.txt";
            //   File.WriteAllText(source, "");
            //   string dest = @"C:\\Users\\aryan\\OneDrive\\Desktop\\Bridgelab\\BridgeLabz-Training-Apexon\\FileHandling\destination.txt";
            //   File.WriteAllText(dest, "");
            //   using (StreamWriter write = new StreamWriter(source))
            //   {
            //       write.WriteLine("Aryan");
            //       write.WriteLine("Gupta");
            //   }
            //   //Copying File here we need to add true so that it can overwrite here but if we dont make dest file before then we dont need to add true
            //   File.Copy(source,dest,true);

            //   // Moving File yah par true wagera kuch nahi lageta
            //   /*
            //     In newer .NET versions, there is:

            //    File.Move(source, dest, overwrite: true);
            //   */
            ////   File.Move(source, dest,overwrite:true);

            //   Console.WriteLine("--------------------------------------");
            //   Console.WriteLine("Using FileInfo");


            //   string filesrc = @"C:\\Users\\aryan\\OneDrive\\Desktop\\Bridgelab\\BridgeLabz-Training-Apexon\\FileHandling\filinfo.txt";

            //   FileInfo file = new FileInfo(filesrc);
            //   using (file.Create()) { }

            //   using (StreamWriter writer = new StreamWriter(filesrc))
            //   {
            //       writer.WriteLine("Aryan");
            //       writer.WriteLine("Gupta");
            //   }
            //   Console.WriteLine(file.Name);
            //   Console.WriteLine(file.FullName);
            //   Console.WriteLine(file.Length);
            //   Console.WriteLine(file.CreationTime);
            //   Console.WriteLine(file.Extension);

            //   Console.WriteLine("_________________________________--------------");
            //   Console.WriteLine("Directory");

            //   string dirpath = @"C:\Users\aryan\OneDrive\Desktop\BridgeLabz\MyFolder";
            //   Directory.CreateDirectory(dirpath);

            //   string[] files = Directory.GetFiles(path);

            Student student = new Student
            {
                Id = 1,
                Name = "Aryan",
                Age = 22
            };

            string path = @"C:\\Users\\aryan\\OneDrive\\Desktop\\Bridgelab\\BridgeLabz-Training-Apexon\\FileHandling\studentjson.txt";

            // Converting object to json
            string jsonData = JsonSerializer.Serialize(student);

            // Writing json to  file 
            File.WriteAllText(path, jsonData);
            Console.WriteLine("Object serialized and saved");

            // Now deserialization

            string jsonFormFile = File.ReadAllText(path);

            Student studentobj = JsonSerializer.Deserialize<Student>(jsonFormFile);

            Console.WriteLine(studentobj.Name);
            Console.WriteLine(studentobj.Age);
            Console.WriteLine("Object Deserialized");
            /*
             List<Student> students = new List<Student>
                                  {
                              new Student{ Id=1, Name="Aryan", Age=22 },
                              new Student{ Id=2, Name="Rohit", Age=23 }
                                        };

                    string json = JsonSerializer.Serialize(students);
                    File.WriteAllText(path, json);

             */

/*
    string jsonData = File.ReadAllText(path);
    List<Student> studentList = JsonSerializer.Deserialize<List<Student>>(jsonData);

    foreach (var s in studentList)
    {
        Console.WriteLine($"{s.Id} {s.Name}");
    }


 */

/*
 Using using Statement
using (FileStream fs = new FileStream("student.json", FileMode.Create))
{
JsonSerializer.Serialize(fs, student);
}
*/


}
}
}
