using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(String[] args)
        {
            Android android = new Android();
            Iphone iPhone = new Iphone();

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Recharging android with MicroUsb");
            AdapterDemo.rechargeMicroUsbPhone(android);

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Recharging iPhone with Lightning");
            AdapterDemo.rechargeLightningPhone(iPhone);

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Recharging iPhone with MicroUsb");
            AdapterDemo.rechargeMicroUsbPhone(new LightningToMicroUsbAdapter(iPhone));

            Console.WriteLine("---------------------------------------------------------");

            int?[][] matrix = new int?[][]
            {
                new int?[] {1, 2, 3, 4, 5},
                new int?[] {1, 4, 9, 16, 25}
            };

            Dictionary<int?, int?> hashMap = new HashMapAdapter<int>(matrix);

            Console.WriteLine("Elementos da matrix");

            foreach (int? key in hashMap.Keys)
            {
                Console.WriteLine((key + (" : " + hashMap.GetValueOrDefault(key))));
            }

            Console.ReadKey();
        }
    }
}
