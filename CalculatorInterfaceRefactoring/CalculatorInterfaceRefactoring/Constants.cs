using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    public class Constants
    {
        //DRY principle Do Not Repeat Yourself in case some constant is needed somewhere else
        //If I ever need to extend the logic of the calculator I will add new key-value pairs here:
        public static IDictionary<int, string> numberNames = new Dictionary<int, string>()
        {
            { 1 , "one"},
            { 2 , "two"},
            { 3 , "three"}
        };

        //DRY principle Do Not Repeat Yourself
        public static string resultIsConstant = "Result is:";

        //DRY principle Do Not Repeat Yourself
        public static string calcExecutingConstant = "Calc{0} executing!";
        //test sharing111111111
    }
}
