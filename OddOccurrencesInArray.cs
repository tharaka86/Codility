using System;
using System.Linq;
class Solution
{
    public int solution(int[] A)
    {
        if (A.Length == 0) return 0;
        if (A.Length == 1) return A[0];
        return A.GroupBy(a => a).Select(g => new
        {
            k = g.Key,
            c = g.Count()
        }).Where(s => s.c % 2 != 0).Select(m => m.k).FirstOrDefault();
    }
}