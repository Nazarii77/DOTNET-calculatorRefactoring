using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    class CalculatorTypeTwoClass : CalculatorClass
    {

        private string _type;

        public override string Type
        { get; set; } = "two";
        public CalculatorTypeTwoClass(string type )
        {
            _type = type; 
        }

        public override string Calculate(int num)
        {   // one million lines of code
            // one million lines of code
            // one million lines of code

            Console.WriteLine("hello from calculator class two");
            return $"{Constants.resultIsConstant} {num + Constants.numberNames.FirstOrDefault(x => x.Value == Type).Key}";
        }
    }
}
