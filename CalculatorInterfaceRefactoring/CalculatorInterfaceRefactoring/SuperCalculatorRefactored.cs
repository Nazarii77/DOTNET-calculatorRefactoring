using CalculatorInterfaceRefactoring.CalculatorMethods;
using System;
using System.Linq;

namespace CalculatorInterfaceRefactoring
{
    partial class SuperCalculatorRefactored : SuperCalculator
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
                    return CalculateOne(type, num);
                case "two":
                    return CalculateTwo(type, num);
                case "seventyseven":
                    return CalculateSeventySeven(type, num);
                default:
                    logStart(type);
                    return $"{Constants.resultIsConstant} {num + Constants.numberNames.FirstOrDefault(x => x.Value == type).Key}";
            }
        }

    }
}
