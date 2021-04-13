using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    abstract class Creator
    {
        public abstract Calculator FactoryMethod();
    }
}
