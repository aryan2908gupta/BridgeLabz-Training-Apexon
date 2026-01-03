using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy
{
    internal class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading image: " + fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying image: " + fileName);
        }
    }
}
