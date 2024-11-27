namespace Arrays;

internal class Program
{
    private static void Main()
    {
        var number = new int[3];
        /*
         * Eğer ki dizilerin içerisine değer atamazsanız her indeksi 0 olur
         * Aşağıdaki for döngüsünü çalıştırdığım zaman aldığım sonuç
         */
        // for (int i = 0; i <= number.Length; i++)
        // {
        //     Console.WriteLine($"Element at index {i + 1} is  {number[i]} ");
        // }
        /*
         * Eğer ki içerisine değer eklemek istediğimiz zaman number[n] = "eklemek istenilen deger";
         * Example:   number[n] = 31;
         * Bunu ben asagida Random ile yapacam;
         */
        // for (var i = 0; i <= number.Length; i++)
        // {
        //     var rnd = new Random();
        //     var random = rnd.Next(1, 10);
        //     Console.WriteLine($"Element at index {i + 1} is  {number[i] = random} ");
        // }
        //
        // var numbers = new[] { 2, 4, 8, 9 };


        var letters = new char[] { 'a', 'b', 'c'};
        for (int i = 0; i <= letters.Length; i++)
        {
            Console.WriteLine(letters[i]);
        }
    }
}