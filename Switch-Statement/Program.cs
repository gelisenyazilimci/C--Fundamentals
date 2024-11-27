namespace Switch_Statement;

internal class Program
{
    private static void Main()
    {
        var userChoice = Console.ReadLine()!.ToUpper();
        PrintSelectedOption(userChoice);
    }
     private static void PrintSelectedOption(string selectedOption)
     {
         switch (selectedOption)
         {
            case "S" :
                Console.WriteLine("Selected option: See all TODOs");
                break;
            case "A":
                Console.WriteLine("Selected option: Add a TODO");
            break;
            case "R":
                Console.WriteLine("Selected option: Remove a TODO");
                break;
            case "E":
                Console.WriteLine("Selected option: Exit");
                break;
            default:
                Console.WriteLine("ERROR");
                Main();
                break;
         }
     }
}