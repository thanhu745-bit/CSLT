using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //1. to Add / Sum Two Numbers.
        int a = 100;
        int b = 200;
        Console.WriteLine($"Sum Two Numbers {a + b}");

        //2. to Swap Values of Two Variables.
        Console.WriteLine($"Before Swapping: a = {a}, b = {b}");
        int c = a;
        a = b;
        b = c;
        Console.WriteLine($"After Swapping: a = {a}, b = {b}");

        //3. to Multiply two Floating Point Numbers
        float e = 10.5f;
        float f = 20.5f;
        Console.WriteLine($"Multiply of {e} and {f} is {e * f}");

        //4. to convert feet to meter
        const float feetToMetre = 0.3048f;
        float feet = 10.5f;
        Console.WriteLine($"{feet} feet is equal to {feet * feetToMetre} metres");

        //5. to convert Celsius to Fahrenheit and vice versa
        float celsius = 36.5f;
        Console.WriteLine($"{celsius} Celsius is equal to {(celsius * 1.8f) + 32} Fahrenheit");
        float fahrenheit = 97.7f;
        Console.WriteLine($"{fahrenheit} Fahrenheit is equal to {(fahrenheit - 32) * 5 / 9} Celsius");

        //6. to find the Size of data types
        Console.WriteLine($"Size of int: {sizeof(int)} bytes");
        Console.WriteLine($"Size of float:{sizeof(float)} bytes");

        //7. to Print ASCII Value (tip: read character, print number of this char)
        char character = 'U';
        Console.WriteLine($"ASCII code of {character} is {(int)character}");

        //8. to Calculate Area of Circle
        const double pi = 3.14159;
        double r = 10.0;
        Console.WriteLine($"Area of Circle with r = {r} is {pi * r * r}");

        //9. to Calculate Area of Square
        int canh = 10;
        Console.WriteLine($"Area of Square with canh = {canh} is {canh * canh}");

        //10. to convert days to years, weeks and days
        int days = 1000;
        Console.WriteLine($"{days} days is equal to {days / 365} years, {(days % 365) / 7} weeks and {(days % 365) % 7} days");

        Console.ReadKey();




    }
}