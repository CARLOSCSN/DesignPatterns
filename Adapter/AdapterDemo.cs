using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AdapterDemo
    {
        public static void rechargeMicroUsbPhone(MicroUsbPhone phone)
        {
            phone.useMicroUsb();
            phone.recharge();
        }

        public static void rechargeLightningPhone(LightningPhone phone)
        {
            phone.useLightning();
            phone.recharge();
        }
    }
}
