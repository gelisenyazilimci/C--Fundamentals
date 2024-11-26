namespace Boolean_Type_Logical_Negation_Equality_Comparison_And_Modulo_Operators;

class Program
{
    private static void Main(string[] args)
    {
        string userChoice = Console.ReadLine();
        bool isUserInputAbc = userChoice == "ABC"; // true
        bool isUserInputAbc2 = !(userChoice != "ABC"); // ture
        bool isUserInputNotAbc = userChoice != "ABC"; // false
        bool isUserInputNotAbc2 = !(userChoice == "ABC"); // false

        var nn = 10;

        var isLargerThan5 = nn > 5; // ture
        var isLargerThan10 = nn > 10; // false
        var isLargerOrEqualTo10 = nn >= 10; // true
        var isSmallerOrEqualTo5 = nn <= 5; // false

    }
}