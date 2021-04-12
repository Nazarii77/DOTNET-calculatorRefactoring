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
        internal void Calculate(string type,int num)
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = this._strategy.Calculate(type, num);
        }
    } 
 
    class Program
    {
        static void Main(string[] args)
        {

            //Trying to do with STRATEGY pattern

            var context = new Context();

            Console.WriteLine("Client: Calculator is set to SuperCalculator.");
            context.SetStrategy(new SuperCalculator());
            context.Calculate("one", 234);

            Console.WriteLine();

            Console.WriteLine("Client: Calculator is set to SuperCalculatorRefactored.");
            context.SetStrategy(new SuperCalculatorRefactored());
            context.Calculate("three", 345);


            // I suppose here can be used Factory method:
            // To generate different types of calculators
            // All the Calculators will do the Calculate
            // The Calculate functionality can be implemented in various ways depending on the type of the calculator
            var calculator = new SuperCalculator();
            var calculatorRefactored = new SuperCalculatorRefactored(); 
            //Creational factory
            calculator.Calculate("one", 123); 
            calculator.Calculate("two", 123);
            //Creational factory
            calculatorRefactored.Calculate("one", 123456);
            calculatorRefactored.Calculate("two", 123456);
            calculatorRefactored.Calculate("three", 123456);

            //IF we had type at the beginning:
            //var cf = new CalculatorFactory();
            //var c1 = pf.CreateCalculator("one");
            //var c2 = pf.CreateCalculator("three");
        }
    }
}
