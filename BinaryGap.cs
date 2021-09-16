using System;
using System.Linq;

class Solution
{
    public int solution(int N)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if (N == 0) return 0;
        var binary = Convert.ToString(N, 2);
        var charArray = binary.ToCharArray();
        if (charArray.Count(c => c == '1') <= 1)
        {
            return 0;
        }
        int maxGap = 0;
        int currentGap = 0;
        foreach (var i in charArray)
        {
            if (i == '0')
            {
                currentGap++;
            }
            else
            {
                maxGap = currentGap > maxGap ? currentGap : maxGap;
                currentGap = 0;
            }
        }
        return maxGap;
    }
}