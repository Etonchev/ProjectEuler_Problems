using System;
using System.Diagnostics;

class LargestPrimeFactor
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
        //The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143 ?

        long number = 600851475143;
        for (long i = 2; i < number; i++)
        {
            if (isPrime(number))
            {
                break;
            }
            while (number % i == 0)
            {
                number /= i;
            }
        }
        Console.WriteLine(number);
    }
}
