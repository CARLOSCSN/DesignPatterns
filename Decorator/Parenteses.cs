using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Parenteses : DecoratorUm
    {
        string left = "( ";
        string right = " )";
        BaseUm _number;

        public Parenteses(BaseUm number)
        {
            _number = number;
        }

        public override string Um
        {
            get
            {
                return left + _number.Um + right;
            }
        }
    }
}