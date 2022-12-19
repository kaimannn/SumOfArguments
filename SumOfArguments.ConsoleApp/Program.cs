using SumOfArguments.ConsoleApp.Extensions;
using SumOfArguments.ConsoleApp.Services;

try
{
    if (args.Length != 2)
    {
        Console.WriteLine("Two arguments must be provided");
        return;
    }

    Console.WriteLine($"The two entered arguments are '{args[0]}' and '{args[1]}'");

    var sumModel = args[0].Sum(args[1]);
    Console.WriteLine(sumModel.ToString());

    using var dbService = new DbService();
    _ = await dbService.SaveAsync(sumModel);
    Console.WriteLine($"The sum of the two arguments has been inserted into the DB");

    var sums = await dbService.GetAllSumsAsync();
    if (sums?.Count == 0)
    {
        Console.WriteLine("The DB is empty");
        return;
    }

    Console.WriteLine($"The list of arguments in the DB is:");
    foreach (var sum in sums)
        Console.WriteLine($"(A: '{sum.A}', B: '{sum.B}')");

}
catch (Exception ex)
{
    Console.WriteLine($"Main.Crashed: {ex.Message}");
}