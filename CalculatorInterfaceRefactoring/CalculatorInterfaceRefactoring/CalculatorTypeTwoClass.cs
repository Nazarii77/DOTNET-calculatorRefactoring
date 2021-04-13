using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    class CalculatorTypeTwoClass : CalculatorClass
    {

        private string _type;
        private int _num;

        public override string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override int Num
        {
            get { return _num; }
            set { _num = value; }

        }
        public CalculatorTypeTwoClass(string type, int num)
        {
            _type = type;
            _num = num;
        }

        public override string Calculate(string type, int num)
        {   // one million lines of code
            // one million lines of code
            // one million lines of code

            Console.WriteLine("hello from calculator class two");
            return "test";
        }
    }
}
