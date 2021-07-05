using System;
using System.Collections.Generic;

namespace AlgoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = (compareTriplets(new List<int>(){1,2,3}, new List<int>(){3,2,1}));
            
            foreach (var num in x)
                Console.WriteLine(num);
        }
    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var aScore = 0;
        var bScore = 0;
        for( var i = 0; i < 3; i++)
        {
            if (a[i] < b[i])
                bScore++;
            if (a[i] > b[i])
                aScore++;
        }
        return new List<int>(){aScore, bScore};
    }
    }
}
