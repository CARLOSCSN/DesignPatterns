using System;
using System.Collections.Generic;
using System.Text;

namespace Coposite
{
    interface IObjeto
    {
        List<IObjeto> Conteudo { get; set; }
        String Nome { get; set; }
        int Nivel { get; set; }

        // Operation
        void Adicionar(IObjeto o);
    }
}
