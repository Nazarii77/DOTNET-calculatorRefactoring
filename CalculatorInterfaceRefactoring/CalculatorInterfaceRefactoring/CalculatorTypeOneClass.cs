using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    class CalculatorTypeOneClass : CalculatorClass
    {
        private string _type;
        public override string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public CalculatorTypeOneClass (string type)
        {
            _type = type;
        }

        public override string Calculate(int num)
        {
            // one million lines of code
            // one million lines of code
            // one million lines of code
            Console.WriteLine("hello from calculator class one");
            return "";
        }
    }
}
