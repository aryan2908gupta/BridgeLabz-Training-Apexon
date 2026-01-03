using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy
{
    internal class ProxyImage : IImage
    
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName); // lazy loading
            }
            realImage.Display();
        }

    }
}
