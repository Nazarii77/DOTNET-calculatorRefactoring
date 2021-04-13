using System;
using System.Linq;

namespace CalculatorInterfaceRefactoring
{
    class SuperCalculatorRefactored : SuperCalculator, IStrategy
    { 
        public void logStart(string type)
        {
            Console.WriteLine(String.Format(Constants.calcExecutingConstant, char.ToUpper(type[0]) + type.Substring(1)));
        }
        public string Calculate(string type, int num)
        {
            switch (type)
            {
                case "one":
                case "two":
                    return base.Calculate(type, num);
                default:
                    logStart(type);
                    return $"{Constants.resultIsConstant} {num + Constants.numberNames.FirstOrDefault(x => x.Value == type).Key}";
            }
        }         
    }
}
