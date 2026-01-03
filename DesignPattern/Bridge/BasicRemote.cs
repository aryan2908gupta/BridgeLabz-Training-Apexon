using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    internal class BasicRemote : RemoteControl
    {
        public BasicRemote(IDevice device) : base(device) { }

        public override void On() => device.TurnOn();
        public override void Off() => device.TurnOff();

    }
}
