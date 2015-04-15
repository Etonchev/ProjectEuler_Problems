using System;

class SummationOfPrimes
{
    static void Main()
    {
        //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17. Find the sum of all the primes below two million.
        int max = 2000000;
        long sum = 0;

        //Using Sieve of Eratosthenes algorithm
        bool[] isPrime = new bool[max];

        for (int i = 2; i < max; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i < max; i++)
        {
            if (isPrime[i])
            {
                for (int j = 2; i * j < max; j++)
                {
                    isPrime[i * j] = false;
                }

                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}