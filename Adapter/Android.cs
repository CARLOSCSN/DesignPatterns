using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Android : MicroUsbPhone
    {
        private bool connector;

        public void useMicroUsb()
        {
            this.connector = true;
            Console.WriteLine("MicroUsb connected");
        }

        public void recharge()
        {
            if (this.connector)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Connect MicroUsb first");
            }

        }
    }
}
