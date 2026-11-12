using System;


class Program
{
    static void Main()
    {
        int a = 10;
        int b = 7;
        double c = 12.5;
        double d = 16.7;

       
        double prosjek = (a + b + c + d) / 4.0;

        
        Console.WriteLine("Zadanih vrijednosti:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
        Console.WriteLine($"d = {d}");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Prosječna vrijednost iznosi: {prosjek}");
    }
}
