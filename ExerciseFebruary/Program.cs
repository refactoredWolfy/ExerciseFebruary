using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;



public class Programm
{

    public static void Main(string[] args)
    {

        int[] numbers = { 1, 2, 2, 2, 2, 2, 3, 4, 4, 7, 7, 8, 9, 9, 9, 9, 9, 7 };
        int mostFrequentNumber = MostFrequentNumber(numbers);
        Console.WriteLine(mostFrequentNumber);
        Console.ReadKey();

    }


    public static int MostFrequentNumber(int[] numbers)
    {


        if (numbers == null || numbers.Length == 0) return 0;

        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (int n in numbers)
        {

            if (!count.ContainsKey(n))
            {
                count[n] = 1;

            }
            else
            {
                count[n]++;

            }

        }

        int maxCount = 0;
        int result = int.MinValue;


        foreach (var pair in count)
        {

            if (pair.Value > maxCount || pair.Value == maxCount && pair.Key < result)
            {
                maxCount = pair.Value;
                result = pair.Key;
            }
        }

        return result;

    }

    




}