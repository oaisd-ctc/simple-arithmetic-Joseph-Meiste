using System;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Provide 1 number to perform the addition operation.");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(x + " …got it. Provide a number to add to " + x + ".");
        int y = int.Parse(Console.ReadLine());

        int result = (x + y);

        Console.WriteLine(y + ", alright! That’s easy. " + x + " + " + y + " is " + result + "!");
    }
}