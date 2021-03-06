using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    class SuperCalculator
    { 
        // 1. Suppose you have some legacy class with Calculate() method
        // 2. This method is a public and used by many other classes, you are not allowed to change method signature
        // 3. What issues do you see in this code?
        // 4. Suppose you were asked to extend class functionality to add new calculation logic defined by "type" parameter, how you implement it?
        // 5. How you can refactor this code to add new functionality?

        public string Calculate(string type, int num)
        {

            #region test

            #endregion test


            //TODO: code to be refactored
            if (type == "one")
            {
                Console.WriteLine("CalcOne executing!");

                // A lot of complex computations going here!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                return $"Result is: {num + 1}";
            }
            else if (type == "two")
            {
                Console.WriteLine("CalcTwo executing!");

                // A lot of complex computations going here!!!
                // Many-many-many lines of code!!!!
                // Fixed bug!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!

                return $"Result is: {num + 2}";
            }
            else if (type == "three")
            {

                // A lot of complex computations going here!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!
                // Many-many-many lines of code!!!!

                return $"Result is: {num + 3}";
            }
            return "";
        }

 
    }
}
