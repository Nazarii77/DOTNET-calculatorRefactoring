using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorInterfaceRefactoring
{ // The Context defines the interface of interest to clients.
  
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new SuperCalculator();
            var calculatorRefactored = new SuperCalculatorRefactored();
            calculator.Calculate("one", 123);
            calculator.Calculate("two", 123);
            calculatorRefactored.Calculate("three", 123456);
            calculatorRefactored.Calculate("one", 123456);
            calculatorRefactored.Calculate("one", 123456);
            calculatorRefactored.Calculate("two", 123456);


            CalculatorFactory factory = null;
            Console.Write("Enter the Calculator type you would like to visit: ");
            string calculatorByFactory = Console.ReadLine();

            switch (calculatorByFactory.ToLower())
            {
                case "one":
                    factory = new CalculatorTypeOneClassFactory();
                    break;
                case "two":
                    factory = new CalculatorTypeOneClassFactory();
                    break;
                case "three":
                    factory = new CalculatorTypeTwoClassFactory();
                    break;
                default:
                    factory = new CalculatorTypeTwoClassFactory();
                    break;
            }

            var properTypeOfCalculator  = factory.GetCalculator();

            properTypeOfCalculator.Calculate("one", 1234);
            properTypeOfCalculator.Calculate("two", 1234);
            properTypeOfCalculator.Calculate("does not matter", 1234);
        }
    }
}
