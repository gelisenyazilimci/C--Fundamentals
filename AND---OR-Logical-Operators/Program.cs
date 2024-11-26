namespace AND___OR_Logical_Operators;

internal static class Program
{
    private static void Main(string[] args)
    {
        var userChoise = Console.ReadLine();
        var num = 10;
        var isLargerThan4AndSmallerThan9 = num > 4 && num < 9;
        var isEqualTo20LargerThan6OrSmaller200 = num == 2 || num > 6 || num < 200;
    }
}