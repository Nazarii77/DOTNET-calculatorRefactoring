using System;
using System.Linq; 

namespace CalculatorInterfaceRefactoring
{
    partial class SuperCalculatorRefactored
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
                    //composition
                    var superCalculator = new SuperCalculator();
                    return superCalculator.Calculate(type, num);
                case "three":
                    var calculator = new CalculatorTypeTwoClass(type);
                    return calculator.Calculate(num);
                case "seventyseven":
                    var calculator77 = new CalculatorTypeTwoClass(type);
                    return calculator77.Calculate(num);
                default:
                    logStart(type);
                    return $"{Constants.resultIsConstant} {num + Constants.numberNames.FirstOrDefault(x => x.Value == type).Key}";
            }
        }

    }
}
