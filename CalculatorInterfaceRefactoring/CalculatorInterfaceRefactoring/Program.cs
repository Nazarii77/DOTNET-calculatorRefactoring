using System;

namespace CalculatorInterfaceRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new SuperCalculator();
            var calculatorRefactored = new SuperCalculatorRefactored(); 

            calculator.Calculate("one", 123); 
            calculator.Calculate("two", 123);


            calculatorRefactored.Calculate("one", 123456);
            calculatorRefactored.Calculate("two", 123456);
            calculatorRefactored.Calculate("three", 123456); 
        }
    }
}
