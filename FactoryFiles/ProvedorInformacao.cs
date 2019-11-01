using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace FactoryFiles
{
    public abstract class ProvedorInformacao
    {
        public abstract string RecuperarInformacao();

        public virtual void exibirInformacao()
        {
            Console.WriteLine(RecuperarInformacao());
        }
        internal static string GetFromResources(string resourceName)
        {
            Assembly assem = Assembly.GetExecutingAssembly();

            using (Stream stream = assem.GetManifestResourceStream(assem.GetName().Name + '.' + resourceName))
            {
                using (var reader = new StreamReader(stream, Encoding.GetEncoding("iso-8859-1")))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
