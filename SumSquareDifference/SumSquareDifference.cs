using System;

class SumSquareDifference
{
    static void Main()
    {
        //The sum of the squares of the first ten natural numbers is, 12 + 22 + ... + 102 = 385 
        //The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)2 = 552 = 3025
        //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 
        //3025 − 385 = 2640. 
        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

        int max = 10;

        long sumSquare = 0;
        long squareSum = 0;

        sumSquare = (long)((max / 6.0) * (max + 1) * (2 * max + 1));
        squareSum = (long)Math.Pow(((1 + max) / 2.0) * max, 2);

        Console.WriteLine(squareSum - sumSquare);
    }
}
