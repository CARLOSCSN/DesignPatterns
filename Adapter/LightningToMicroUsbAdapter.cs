using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class LightningToMicroUsbAdapter : MicroUsbPhone
    {
        private LightningPhone lightningPhone;

        public LightningToMicroUsbAdapter(LightningPhone lPhone)
        {
            lightningPhone = lPhone;
        }

        public void useMicroUsb()
        {
            Console.WriteLine("MicroUsb connected");
            this.lightningPhone.useLightning();
        }

        public void recharge()
        {
            this.lightningPhone.recharge();
        }
    }
}
