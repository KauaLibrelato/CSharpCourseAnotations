using System;
using Delegates.Services;
namespace Delegates {
    //delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program {
        static void Main(string[] args) {

            /*
            double a = 10;
            double b = 12;
            double result = CalculationService.Sum(a, b);
            Console.WriteLine("Sum: " + result);

            BinaryNumericOperation op = CalculationService.Sum;
            result = op.Invoke(a, b);
            //result = op(a, b);
            Console.WriteLine(result);
            */

            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op.Invoke(a, b);
            op(a, b);

        }
    }
}