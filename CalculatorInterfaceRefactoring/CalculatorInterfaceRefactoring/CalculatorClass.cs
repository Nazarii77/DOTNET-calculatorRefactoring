using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    /// <summary>  
    /// The 'Product' Abstract Class  
    /// </summary>  
    abstract class CalculatorClass
    {
        public abstract string Type { get; set; }

        public abstract string Calculate(int num);
    }
}
