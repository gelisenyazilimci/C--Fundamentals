namespace ForEach_Loop;

internal static class Program
{
    public static void Main(string[] args)
    {
        var words = new[] {"one", "two", "three"};
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}