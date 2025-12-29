using System;
using System.Collections.Generic;
using System.Text;

namespace FileHandling
{
    internal class bufferstreamex
    {
        public void fileHandling()
        {
            /*
             1️⃣ Streams don’t read everything at once

bs.Read(...) does NOT guarantee it will read the entire file in one go.

It reads up to buffer.Length

It returns how many bytes were actually read

When it returns 0 → end of stream

That’s why the while loop exists.

2️⃣ Why bytesRead is important

Suppose your file has 1500 bytes.

Read Call	Bytes Read
1st read	1024
2nd read	476
3rd read	0 (EOF)

If you ignored bytesRead and did this ❌:

Encoding.UTF8.GetString(buffer);


You would:

Print old leftover bytes

Print garbage characters

Corrupt output
             */
            string path = "abc.txt";
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = bs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.Write(text);
                }

            }

            // Writing
            using (FileStream fs = new FileStream("data.txt", FileMode.Create, FileAccess.Write))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                byte[] data = Encoding.UTF8.GetBytes("Hello BufferedStream");
                bs.Write(data, 0, data.Length);
                bs.Flush(); // forces write to disk
            }

            // Flush() pushes buffered data to the file.

        }
    }
}
