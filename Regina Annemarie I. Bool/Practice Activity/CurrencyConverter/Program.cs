using System;

public class CurrencyConverter
{
    public static void Main(string[] args)
    {
        Console.Write("Enter amount in USD: ");
        double amt = double.Parse(Console.ReadLine());

        Console.Write("Enter exchange rate from USD to EUR: ");
        double rate = double.Parse(Console.ReadLine());

        double ans = amt * rate;

        Console.Write($"Amount in EUR: {ans:F2}");
    }
}