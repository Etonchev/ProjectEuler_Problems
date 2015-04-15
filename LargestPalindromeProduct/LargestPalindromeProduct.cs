using System;

class LargestPalindromeProduct
{
    static bool isPalindrome(long number)
    {
        long reverse = 0;
        long copy = number;
        while (copy != 0)
        {
            reverse *= 10;
            reverse += copy % 10;
            copy /= 10;
        }
        if (reverse == number)
        {
            return true;
        }
        return false;
    }
    static void Main()
    {
        //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 
        //9009 = 91 × 99. Find the largest palindrome made from the product of two 3-digit numbers.

        long largest = 0;
        for (int i = 0; i < 1000; i++)
        {
            for (int j = 0; j < 1000; j++)
            {
                if (isPalindrome(i*j) && i*j > largest)
                {
                    largest = i * j;
                }
            }
        }
        Console.WriteLine(largest);
    }
}
