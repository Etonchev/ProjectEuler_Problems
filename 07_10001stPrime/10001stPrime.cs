using System;

class Prime10001st
{
    static bool isPrime(long n)
    {
        for (long i = 2; i <= Math.Floor(Math.Sqrt(n)); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number?

        int primeNumber = 10001;
        int br = 0;
        long result = 0;

        for (int i = 2; br < primeNumber; i++)
        {
            if (isPrime(i))
            {
                br++;
                result = i;
            }
        }

        Console.WriteLine(result);
    }
}
