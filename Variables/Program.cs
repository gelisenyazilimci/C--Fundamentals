namespace Variables;

internal static class Program
{
    private static void Main(string[] args)
    {
        // char tek bir harfi tutar
        char key = Convert.ToChar(Console.ReadLine().ToUpper());
        Console.WriteLine(key);
        // string metni uzerinde tutmamizi saglar ve " " arasina yazilmalidir. 
        string input = "hello world";
        // kullanicidan tam sayi degeri almamizi saglar; 
        int inputInt = Convert.ToInt32(input);
        // boolean dedigimiz arkadas aslinda true veya false gibi degerlere bakar
        bool inputBool = Convert.ToBoolean(input);
        
        // bu sekilde tanimlanip sonradan degere eklenilebilir. 
        int a,b,d;

        a = 62;
        b = 31; 
        
        
        // var her türlü verinin yerine geçebilir! 
        // var için diğer değişkenlerdeki gibi bir şey yapmanıza gerek yoktur. 
        // program kendisi anlar. 
        // var diğer operetörler gibi boş bırakılması tavsiye edilmez ve program hata verir. 
        
        
        var c = a / b;

        
        string @class = Console.ReadLine();
        
        a = Convert.ToInt32(Console.ReadLine());
    }
}