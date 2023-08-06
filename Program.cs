using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Testing DisplaySum method
        Console.WriteLine("Testing DisplaySum method:");
        DisplaySum(10, 5);

        // Testing AverageOfFiveDoubles method
        Console.WriteLine("\nTesting AverageOfFiveDoubles method:");
        Console.WriteLine(AverageOfFiveDoubles(1.2, 2.3, 3.4, 4.5, 5.6));

        // Testing SumOfRandomInts method
        Console.WriteLine("\nTesting SumOfRandomInts method:");
        Console.WriteLine(SumOfRandomInts());

        // Testing IsSumDivisibleByThree method
        Console.WriteLine("\nTesting IsSumDivisibleByThree method:");
        Console.WriteLine(IsSumDivisibleByThree(9, 3, 6));

        // Testing DisplayShorterString method
        Console.WriteLine("\nTesting DisplayShorterString method:");
        DisplayShorterString("short", "very long string");

        // Testing MaxInArray method
        Console.WriteLine("\nTesting MaxInArray method:");
        double[] arr = new double[] { 1.2, 2.3, 3.4, 4.5, 5.6 };
        Console.WriteLine(MaxInArray(arr));

        // Testing GenerateIntArray method
        Console.WriteLine("\nTesting GenerateIntArray method:");
        int[] generatedArray = GenerateIntArray();
        Console.WriteLine($"Generated array of length {generatedArray.Length}");

        // Testing AreBoolsEqual method
        Console.WriteLine("\nTesting AreBoolsEqual method:");
        Console.WriteLine(AreBoolsEqual(true, false));

        // Testing ProductOfIntAndDouble method
        Console.WriteLine("\nTesting ProductOfIntAndDouble method:");
        Console.WriteLine(ProductOfIntAndDouble(5, 2.5));

        // Testing AverageOf2DArray method
        Console.WriteLine("\nTesting AverageOf2DArray method:");
        int[,] array2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine(AverageOf2DArray(array2D));
    }

    // Method to display the sum of two integers
    static void DisplaySum(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    // Method to calculate the average of five doubles
    static double AverageOfFiveDoubles(double a, double b, double c, double d, double e)
    {
        return (a + b + c + d + e) / 5;
    }

    // Method to return the sum of two randomly generated integers
    static int SumOfRandomInts()
    {
        Random rand = new Random();
        return rand.Next() + rand.Next();
    }

    // Method to check if the sum of three integers is divisible by three
    static bool IsSumDivisibleByThree(int a, int b, int c)
    {
        return (a + b + c) % 3 == 0;
    }

    // Method to display the string with fewer characters from two given strings
    static void DisplayShorterString(string a, string b)
    {
        Console.WriteLine(a.Length <= b.Length ? a : b);
    }

    // Method to find the maximum value in an array of doubles
    static double MaxInArray(double[] array)
    {
        return array.Max();
    }

    // Method to generate an array of 50 random integer values
    static int[] GenerateIntArray()
    {
        Random rand = new Random();
        int[] array = new int[50];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next();
        }
        return array;
    }

    // Method to check if two bool variables have the same value
    static bool AreBoolsEqual(bool a, bool b)
    {
        return a == b;
    }

    // Method to return the product of an int and a double
    static double ProductOfIntAndDouble(int a, double b)
    {
        return a * b;
    }

    // Method to calculate the average of a 2D array of integers
    static double AverageOf2DArray(int[,] array)
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
                count++;
            }
        }
        return (double)sum / count;
    }
}