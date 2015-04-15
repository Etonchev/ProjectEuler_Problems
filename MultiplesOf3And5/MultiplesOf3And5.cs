using System;

class MultiplesOf3And5
{
    static void Main()
    {
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
        //The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.

        int max = 1000;

        int divisibleBy3 = 3;
        int divisibleBy5 = 5;
        int sum = divisibleBy3 + divisibleBy5;

        for (int i = 2; divisibleBy3 * i < max || divisibleBy5 * i < max; i++)
        {
            if (divisibleBy3 * i < max)
            {
                sum += divisibleBy3 * i;
            }
            if (divisibleBy5 * i < max)
            {
                sum += divisibleBy5 * i;
            }
        }
        Console.WriteLine(sum);
    }
}