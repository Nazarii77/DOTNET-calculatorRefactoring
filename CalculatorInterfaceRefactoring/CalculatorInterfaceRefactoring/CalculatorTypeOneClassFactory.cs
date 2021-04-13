using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    class CalculatorTypeOneClassFactory : CalculatorFactory
    {

        private string _type;
        private int _num;
        public override CalculatorClass GetCalculator()
        {
            return new CalculatorTypeOneClass(_type, _num);
        }
    }
}
