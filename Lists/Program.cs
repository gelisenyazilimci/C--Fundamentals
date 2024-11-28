namespace Lists;

internal static class Program
{
    private static void Main()
    {
        var lists = new List<string>();
        Console.WriteLine("Count of element is: " + lists);
        
        lists.Add("Hello");


        var list2 = new List<string>
        {
            "one", "two"
        };

        Console.WriteLine("count of `list2` element is: " +list2.Count );
        foreach (var item in list2)
        {
            Console.WriteLine(item);
        }
    }
}