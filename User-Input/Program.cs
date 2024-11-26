namespace User_Input;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]add a TODO");
        Console.WriteLine("[R]emove a TODO");
        Console.WriteLine("[E]xit");

        string input = Console.ReadLine()!;
        Console.WriteLine("User input " + input);

    }
}