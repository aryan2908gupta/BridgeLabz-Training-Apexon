using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    public abstract class RemoteControl
    {
        protected IDevice device;

        protected RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public abstract void On();
        public abstract void Off();
    }
}
