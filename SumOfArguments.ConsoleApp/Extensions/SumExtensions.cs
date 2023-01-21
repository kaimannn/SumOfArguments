using SumOfArguments.ConsoleApp.Models;

namespace SumOfArguments.ConsoleApp.Extensions
{
    public static class SumExtensions
    {
        public static SumModel Sum(this string a, string b)
        {
            if (decimal.TryParse(a, out decimal decimalA) && decimal.TryParse(b, out decimal decimalB))
                return new SumModel { A = a, B = b, Type = typeof(decimal).Name, Result = (decimalA + decimalB).ToString() };

            return new SumModel { A = a, B = b, Type = typeof(string).Name, Result = a + b };
        }
    }
}
