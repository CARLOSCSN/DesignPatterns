using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FactoryFiles
{
    public class ProvedorPublico : ProvedorInformacao
    {
        public override string RecuperarInformacao()
        {
            string readText = GetFromResources("publico.txt");
            StringBuilder buffer = new StringBuilder();

            buffer.Append(readText);
            buffer.Append("\n");

            return buffer.ToString();
        }
    }
}
