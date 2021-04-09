using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorInterfaceRefactoring
{
    class SuperCalculatorRefactored : ICalculatorInterface
    {
        static string resultIsConstant = "Result is:";
        public void logStart()
        {
            Console.WriteLine("CalcOne executing!");
        }

        IDictionary<int, string> numberNames = new Dictionary<int, string>()
        {
            { 1 , "one"},
            { 2 , "two"},
            { 3 , "three"}
        };

        public string Calculate(string type, int num)
        {
            if (type != "" && type != null)
            {
                logStart();
                return $"{resultIsConstant} {num + numberNames.FirstOrDefault(x => x.Value == type).Key}";
            }
            return "";
        }

    }
}
