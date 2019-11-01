using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Iphone : LightningPhone
    {
        private bool connector;

        public void useLightning()
        {
            this.connector = true;
            Console.WriteLine("Lightning connected");
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
                Console.WriteLine("Connect Lightning first");
            }

        }
    }
}
