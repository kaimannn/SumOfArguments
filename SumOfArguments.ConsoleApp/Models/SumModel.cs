namespace SumOfArguments.ConsoleApp.Models
{
    public class SumModel
    {
        public string A { get; set; }
        public string B { get; set; }
        public string Type { get; set; }
        public string Result { get; set; }

        public SumModel()
        {
        }

        public SumModel(DB.Sums sum)
        {
            A = sum.A;
            B = sum.B;
            Type = sum.Type;
            Result = sum.Result;
        }

        public override string ToString() =>
            $"The result of adding '{A}' and '{B}' of type '{Type}' is '{Result}'";
    }
}
