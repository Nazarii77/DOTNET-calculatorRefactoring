using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    abstract class CalculatorFactory
    {    /// <summary>  
         /// The 'Creator' Abstract Class  
         /// </summary>  
        public abstract CalculatorClass GetCalculator();
    }
}
