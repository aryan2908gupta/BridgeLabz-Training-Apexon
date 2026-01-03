using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderDesign
{
    internal class House
    {
        public int Room { get; set; }
        public bool Kitchen { get; set; }
        public bool BathRoom { get; set; }
        public bool Garage { get; set; }

        public void Show()
        {
            Console.WriteLine($"Rooms : {Room},Kitchen : {Kitchen},BathRoom : {BathRoom},Garage : {Garage},");
        }

    }
}

// Product