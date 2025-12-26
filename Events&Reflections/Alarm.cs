using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Reflections
{
    internal class Alarm
    {
        public event EventHandler AlarmRang;
        
        public void Ring()
        {
            Console.WriteLine("Alarm is Ringing");
            AlarmRang?.Invoke(this, EventArgs.Empty);
        }
    }
}
