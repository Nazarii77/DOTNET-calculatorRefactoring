using System;
using System.Linq;

namespace CalculatorInterfaceRefactoring
{
    class SuperCalculatorRefactored
    {   //DRY principle Do Not Repeat Yourself
        public void logStart()
        {
            Console.WriteLine(Constants.calcExecutingConstant);
        }
        // Here is my implementation of the Calculate Method for SuperCalculatorRefactored as I can not touch the original
        public string Calculate(string type, int num)
        {
            //DRY principle Do Not Repeat Yourself
            if (type != "" && type != null)
            {
                logStart();
                return $"{Constants.resultIsConstant} {num + Constants.numberNames.FirstOrDefault(x => x.Value == type).Key}";
            }
            return "";
        }
    }
}
