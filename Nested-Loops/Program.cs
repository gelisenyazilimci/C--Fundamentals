namespace Nested_Loops;
internal class Program
{
    private static void Main()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"is i {i}, is j {j}");
            }
        }
    }
    
}