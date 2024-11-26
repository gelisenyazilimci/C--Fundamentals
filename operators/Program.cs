namespace operators;

internal static class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;

        ++a; 
        Console.WriteLine(a);

        a++; Console.WriteLine(a);
        
        b--; Console.WriteLine(b);
        
        --b; Console.WriteLine(b);
        
        Console.WriteLine(a + b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a - b);
        Console.WriteLine(a % b);
        Console.WriteLine(a ^ b);
        Console.WriteLine(a ^ -b);
        Console.WriteLine("Jhon"+" "+"Depth");
    }
}