using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    public class Tv : IDevice
    {
        public void TurnOn() => Console.WriteLine("TV is ON");
        public void TurnOff() => Console.WriteLine("TV is OFF");
    }

    public class Radio : IDevice
    {
        public void TurnOn() => Console.WriteLine("Radio is ON");
        public void TurnOff() => Console.WriteLine("Radio is OFF");
    }


}
