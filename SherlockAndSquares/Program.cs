using System;

/*
    Watson likes to challenge Sherlock's math ability. He will provide a starting and ending value that describe a range of integers, inclusive of the endpoints. Sherlock must determine the number of square integers within that range.
    Example: 2,9 should return 2 (4,9)
*/
namespace SherlockAndSquares
{
    class Program
    {
        static int squares(int a, int b) 
        {
            int counter = 0;
            for(int i = a; i <= b; i++)
            {
                double sqrt = Math.Sqrt(i);
                if(sqrt == Math.Floor(Math.Sqrt(i)))
                {
                    counter++;
                    //jump from i = 4 to i = 9, for example
                    int sqrtInt = (int)(Math.Sqrt(i)) + 1;
                    i = sqrtInt * sqrtInt;
                    i--;              
                }
            }
        return counter;
    }

        static void Main(string[] args)
        {
            Console.WriteLine(squares(1,26));
        }
    }
}
