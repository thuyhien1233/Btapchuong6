using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = { 1.5, 2.7, 3.9, 4.2, 5.1 };

        double min = FindMin(numbers);
        double max = FindMax(numbers);

        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
    }

    static double FindMin(double[] arr)
    {
        double min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }

    static double FindMax(double[] arr)
    {
        double max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }
}
