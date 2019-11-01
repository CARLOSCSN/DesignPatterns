using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class NumeroUm : BaseUm
    {
        string _um = "1";

        public override string Um
        {
            get
            {
                return _um;
            }
        }
    }
}
