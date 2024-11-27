namespace Project_1_Simple_Calculator;

internal static class Program
{
    private static void Main()
    {
        int num1, num2;
        Console.WriteLine("Hello");
        Console.WriteLine("Input the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What do you want to do ?");
        Console.WriteLine("[A]dd numbers");
        Console.WriteLine("[S]ubtract numbers");
        Console.WriteLine("[M]ultiply numbers");
        var userInput = Console.ReadLine()!.ToUpper();
        Console.WriteLine(userInput == "A" ? 
            $"{num1} + {num2} = {num1 + num2}": userInput == "S" ? $"{num1} - {num2} = {num1 - num2}" :
                userInput == "M" ? $"{num1} * {num2} = {num1 * num2}": "ERROR");
    }
}