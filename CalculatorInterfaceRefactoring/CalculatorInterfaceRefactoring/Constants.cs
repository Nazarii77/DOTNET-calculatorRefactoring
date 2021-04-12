using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    public class Constants
    {
        //DRY principle Do Not Repeat Yourself in case some constant is needed somewhere else
        public static IDictionary<int, string> numberNames = new Dictionary<int, string>()
        {
            { 1 , "one"},
            { 2 , "two"},
            { 3 , "three"}
        };

        //DRY principle Do Not Repeat Yourself
        public static string resultIsConstant = "Result is:";

        //DRY principle Do Not Repeat Yourself
        public static string calcExecutingConstant = "CalcOne executing!";
    }
}
