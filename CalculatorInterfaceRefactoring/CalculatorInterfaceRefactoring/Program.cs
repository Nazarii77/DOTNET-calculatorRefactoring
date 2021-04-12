using System;

namespace CalculatorInterfaceRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            // I suppose here can be used Factory method:
            // To generate different types of calculators
            // All the Calculators will do the Calculate
            // The Calculate functionality can be implemented in various ways depending on the type of the calculator
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
