using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorInterfaceRefactoring
{ // The Context defines the interface of interest to clients.

    class Program
    {
        static void Main(string[] args)
        {
            //Old style:
            var calculator = new SuperCalculator();
            var calculatorRefactored = new SuperCalculatorRefactored();
            calculator.Calculate("one", 123);
            calculator.Calculate("two", 123);
            calculatorRefactored.Calculate("three", 123456);
            calculatorRefactored.Calculate("one", 123456);
            calculatorRefactored.Calculate("one", 123456);
            calculatorRefactored.Calculate("two", 123456);

            //New style Factory Method:
            CalculatorFactory factory = null;
            Console.Write("Enter the Calculator type you would like to visit: ");
            string calculatorByFactory = Console.ReadLine();

            // here you can choose on which factory to produce the calculator:
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

            //Factory creates calculator (factory was choosen and created before)
            var properTypeOfCalculator = factory.GetCalculator();

            properTypeOfCalculator.Calculate(1234);
            properTypeOfCalculator.Calculate(56);
            properTypeOfCalculator.Calculate(234);

            //Factory Method
            var calculatorTypeOneFactory  = new CalculatorTypeOneClassFactory();
            //Factory creates calculator
            var calculatorTypeOneProduct = calculatorTypeOneFactory.GetCalculator();
            //calculator of type "ONE" which was produced on factory of type "ONE"
            calculatorTypeOneProduct.Calculate(213);

            //Factory Method
            var calculatorTypeTwoFactory = new CalculatorTypeTwoClassFactory();
            //Factory creates calculator
            var calculatorTypeTwoProduct = calculatorTypeTwoFactory.GetCalculator();
            //calculator of type "TWO" which was produced on factory of type "TWO"
            calculatorTypeTwoProduct.Calculate(456);

        }
    }
}
