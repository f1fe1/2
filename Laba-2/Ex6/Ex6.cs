using System;
using System.Linq;

class Ex6
{
    static void Main()
    {
        int[] arr = { 0, 1, 1, 5, 2, 2, 6, 3, 3 };

        arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.TryParse(i, out int pars) ? pars : 0).ToArray();

        int n = arr.Length;

        int start = 0;
        int len = 1;

        int bestStart = start;
        int bestLen = len;

        for (int i = 1; i < n; i++)
        {
            if (arr[i - 1] == arr[i])
            {
                len++;

                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }
            if (arr[i - 1] != arr[i])
            {
                start = i;
                len = 1;
            }
        }


        for (int i = bestStart; i < bestStart + bestLen; i++)
            Console.Write($"{arr[i]} ");
    }
}

