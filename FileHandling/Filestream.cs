using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    internal class Filestream
    {
        public void filehandling()
        {
            string path = @"C:\\Users\\aryan\\OneDrive\\Desktop\\Bridgelab\\BridgeLabz-Training-Apexon\\FileHandling\filestream.txt";
            FileStream fs = new FileStream(path,FileMode.Create);
            fs.Close();
            FileStream fs1 = new FileStream(path,FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            string content = sr.ReadToEnd();
            fs1.Close();    
            fs1.Dispose(); // umanaged resources 

            sr.Close();
            Console.WriteLine("File has been created");

            using (FileStream fs2 = new FileStream(path,FileMode.Open, FileAccess.Read)) {
                byte[] buffer = new byte[fs2.Length];
                fs2.Read(buffer, 0, buffer.Length);
                string data = Encoding.UTF8.GetString(buffer);
                Console.WriteLine(data);

            }
           
        }
    }
}
