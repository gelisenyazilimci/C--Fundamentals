namespace While_Loop;

internal class Program
{
    private static void Main()
    {
        var number = 0;

        while (number <  10)
        {
            number++;
            Console.WriteLine(number);
        }

        Console.WriteLine("The is loop fnished");


        Console.WriteLine("Enter a word");
        string input = Console.ReadLine()!;
        while (input.Length < 10)
        {
            input += "a";
            Console.WriteLine(input);
        }
        
        // Do - While
        /*
         do 
         {
         
         // some code
         
         } while ();
         */
        
        // ilk önce do çalışır eğer ki while'ın içerisinde olan denklem sağlanırsa döngü devam eder yoksa 1 kere çalışır
        
        var word = "";
        do
        {
            Console.WriteLine("a");
            word = Console.ReadLine()!;
        } while (word.Length >= 3);
        
        
        
    }
}