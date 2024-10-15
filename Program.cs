using System;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("What operation are you using? 1.Addition 2.Subtraction 3.Multiplication 4.Division 5.Modulus");
        int op = int.Parse(Console.ReadLine());

        if (op == 1)
        {
            Console.WriteLine("Provide 1 number to perform the addition operation.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(x + " …got it. Provide a number to add to " + x + ".");
            int y = int.Parse(Console.ReadLine());

            int add = (x + y);
            Console.WriteLine(y + ", alright! That’s easy. " + x + " + " + y + " is " + add + "!");
        }

        else if (op == 2)
        {
            Console.WriteLine("Provide 1 number to perform the subtraction operation.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(x + " …got it. Provide a number to subtract to " + x + ".");
            int y = int.Parse(Console.ReadLine());

            int sub = (x - y);
            Console.WriteLine(y + ", alright! That’s easy. " + x + " - " + y + " is " + sub + "!");
        }

        else if (op == 3)
        {
            Console.WriteLine("Provide 1 number to perform the multiplication operation.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(x + " …got it. Provide a number to multiply to " + x + ".");
            int y = int.Parse(Console.ReadLine());

            int mul = (x * y);
            Console.WriteLine(y + ", alright! That’s easy. " + x + " * " + y + " is " + mul + "!");
        }

        else if (op == 4)
        {
            Console.WriteLine("Provide 1 number to perform the division operation.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(x + " …got it. Provide a number to divide to " + x + ".");
            int y = int.Parse(Console.ReadLine());

            int div = (x / y);
            Console.WriteLine(y + ", alright! That’s easy. " + x + " / " + y + " is " + div + "!");
        }

        else if (op == 5)
        {
            Console.WriteLine("Provide 1 number to perform the modulus operation.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(x + " …got it. Provide a number to % to " + x + ".");
            int y = int.Parse(Console.ReadLine());

            int mod = (x % y);
            Console.WriteLine(y + ", alright! That’s easy. " + x + " % " + y + " is " + mod + "!");
        }

        else {
            Console.WriteLine("That is not a valid number, please try again.");
        }
    }
}