using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FactoryFiles
{
    public class ProvedorConfidencial : ProvedorInformacao
    {
        public override string RecuperarInformacao()
        {
            string readText = GetFromResources("confidencial.txt");
            StringBuilder buffer = new StringBuilder();

            buffer.Append(readText);
            buffer.Append("\n");

            return buffer.ToString();
        }
    }
}
