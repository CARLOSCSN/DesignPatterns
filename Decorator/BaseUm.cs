using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class BaseUm
    {
        private string _um = "-1";

        public virtual string Um
        {
            get { return _um; }
        }
    }
}
