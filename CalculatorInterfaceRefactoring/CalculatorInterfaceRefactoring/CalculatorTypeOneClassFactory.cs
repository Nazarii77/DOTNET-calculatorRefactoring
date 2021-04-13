using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    class CalculatorTypeOneClassFactory : CalculatorFactory
    {
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override CalculatorClass GetCalculator()
        {
            return new CalculatorTypeOneClass(Type);
        }
    }
}
