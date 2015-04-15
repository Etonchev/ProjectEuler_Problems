using System;

class SpecialPythagoreanTriplet
{
    static bool isPythagoreanTriplet(int a, int b, int c)
    {
        if (a >= b || b >= c || a >= c || (Math.Pow(a, 2) + Math.Pow(b, 2)) != Math.Pow(c, 2))
        {
            return false;
        }
        return true;
    }
    static void Main()
    {
        //A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a2 + b2 = c2
        //For example, 3^2 + 4^2 = 9 + 16 = 2^5 = 52. There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        //Find the product abc.

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int a = 0;
        int b = 0;
        int c = 0;

        for (int n = 2; n < number; n++)
        {
            for (int m = 1; m < n; m++)
            {
                //Using Euclid's formula
                int tempa = 2 * n * m;
                int tempb = n * n - m * m;
                int tempc = n * n + m * m;
                if (tempa + tempb + tempc == number)
                {
                    a = Math.Min(tempa, Math.Min(tempb, tempc));
                    c = Math.Max(tempa, Math.Max(tempb, tempc));
                    b = tempa + tempb + tempc - a - c;
                }
            }
        }
        if (a != 0)
        {
            Console.WriteLine();
            Console.WriteLine("The Pythagorean triplets are: a = {0}, b = {1}, c = {2}", a, b, c);
            Console.WriteLine("{0}^2 + {1}^2 = {2}^2", a, b, c);
            Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
            Console.WriteLine("The product is {0}", a * b * c);
        }
        else
        {
            Console.WriteLine("There are no Pythagorean triplets equal to {0} !", number);
        }
    }
}
