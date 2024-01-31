
/*
 Question no 04

 using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
*/

//Question no 05


    using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Multiplication Table for {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}

