using System;

namespace Singleton
{
    internal class Incremental
    {
        private static Incremental singletonInstance;
        private static int count = 0;
        private int numero;

        private Incremental()
        {
            numero = ++count;
        }

        internal static Incremental Instance
        {
            get
            {
                lock (typeof(Incremental))
                {
                    singletonInstance = new Incremental();

                    return singletonInstance;
                }
            }
        }

        public override string ToString()
        {
            return "Incrementando: " + numero;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Incremental inc = Incremental.Instance;
                Console.WriteLine(inc);
            }

            Console.ReadKey();
        }
    }
}
