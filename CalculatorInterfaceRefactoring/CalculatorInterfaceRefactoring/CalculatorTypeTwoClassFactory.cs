using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    class CalculatorTypeTwoClassFactory : CalculatorFactory
    {

        private string _type;
        private int _num;
        public override CalculatorClass GetCalculator()
        {
            return new CalculatorTypeTwoClass(_type, _num);
        }
    }
}
