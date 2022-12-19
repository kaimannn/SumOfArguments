using SumOfArguments.ConsoleApp.Models;

namespace SumOfArguments.ConsoleApp.Extensions
{
    public static class SumExtensions
    {
        public static SumModel Sum(this string a, string b)
        {
            if (!decimal.TryParse(a, out var decimalA) || !decimal.TryParse(b, out var decimalB))
                return new SumModel { A = a, B = b, Type = a.GetType().Name, Result = a + b };

            return new SumModel { A = decimalA.ToString(), B = decimalB.ToString(), Type = decimalA.GetType().Name, Result = (decimalA + decimalB).ToString() };
        }
    }
}
