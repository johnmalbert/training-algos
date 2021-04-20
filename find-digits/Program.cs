/*
An integer d is a divisor of an integer n if the remainder of d % n == 0.

Given an integer, for each digit that makes up the integer determine whether it is a divisor. Count the number of divisors occurring within the integer.

Example: 1024 will return 3, the digits 1, 2, and 4 are all divisors of 1024. 0 is not.

*/

using System;

namespace find_digits
{
    class Program
    {
        static int findDigits(int n) {
        string s = n.ToString();
        int count = 0;
        for(int i = 0; i < s.Length; i++)
        {
            string place = s[i].ToString();
            int current = Int32.Parse(place);
            if(current != 0)
            {
                if(n % current == 0)
                {
                    count++;
                }
            }
        }
        return count;

    }
        static void Main(string[] args)
        {
            Console.WriteLine(findDigits(1012));
            Console.WriteLine(findDigits(123456));
            Console.WriteLine(findDigits(13));
        }
    }
}
