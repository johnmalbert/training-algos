/*
* Given a sequence of n integers, p(1), p(2),...p(n) where each element is distinct and satasfies 1 <= p(x) <= n
* For each x where 1 <= x <= n, that is x increments from 1 to n, find any integer y such that p(p(y)) = x
* Example: p = [5,2,1,3,4]
* x = 1 => p[3], p[4] = 3, so p[p[4]] = 1...
* the return values are [4,2,5,1,3]
*/
using System;

namespace permutation_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = {4,3,5,1,2};
            var result = permutationEquation(test);

            foreach(int i in result)
                Console.WriteLine(i);
        }
    
    public static int[] permutationEquation(int[] p) {
        int[] ret = new int[p.Length];
        int[] retIndex = new int[p.Length];
        
        for(int i = 0; i < p.Length; i++)
        {
            for(int j = 0; j < p.Length; j++)
            {
                if(p[j] == i+1)
                {
                    retIndex[i] = j+1;
                }
            }
        }
        for(int i = 0; i < p.Length; i++)
        {
            for(int j = 0; j < p.Length; j++)
            {
                if(p[j] == retIndex[i])
                {
                    ret[i] = j+1;
                }
            }
        }
        return ret;
    }
    }
}
