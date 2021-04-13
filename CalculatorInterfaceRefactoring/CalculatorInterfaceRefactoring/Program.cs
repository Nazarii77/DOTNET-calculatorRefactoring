using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorInterfaceRefactoring
{ // The Context defines the interface of interest to clients.
    class Context
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private IStrategy _strategy;

        public Context()
        { }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        internal void Calculate(string type, int num)
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = this._strategy.Calculate(type, num);
        }
    }

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

            var propertypeOfCalculator  = factory.GetCalculator();

            propertypeOfCalculator.Calculate("one", 1234);
        }
    }
}
