//Recursion is a technique where a method calls itself to solve a problem by breaking it down into smaller subproblems.
//It can simplify problems like calculating future values over multiple periods.

using System;

class Program
{
    //Recursive method to calculate future value
    static double FutureValue(double presentValue, double growthRate, int periods)
    {
        if (periods == 0)
            return presentValue;
        return FutureValue(presentValue * (1 + growthRate), growthRate, periods - 1);
    }

    static void Main(string[] args)
    {
        double initial = 1000; //Initial value
        double rate = 0.05;    //5% growth rate
        int years = 5;
        double result = FutureValue(initial, rate, years);
        Console.WriteLine($"Initial value: {initial:C}");
        Console.WriteLine($"Growth rate: {rate:P}");
        Console.WriteLine($"Future value after {years} years: {result:F2}");

        //Analysis
        Console.WriteLine("\nAnalysis:");
        Console.WriteLine("Time complexity: O(n), where n is the number of periods.");
        Console.WriteLine("To optimize, use iteration or memoization to avoid redundant calculations in more complex recurrences.");
    }
}
