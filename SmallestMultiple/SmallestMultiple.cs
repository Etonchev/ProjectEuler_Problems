using System;

class SmallestMultiple
{
    static void Main()
    {
        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder. 
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        int max = 20;
        long number = 1;

        for (int i = 1; i <= max; i++)
        {
            if (number % i != 0)
            {
                var powersOfI = i;
                while (powersOfI <= max)
                {
                    number *= i;
                    powersOfI *= i;
                }
            }
        }
        Console.WriteLine(number);
    }
}