using System;

public class PairDivisibleByK
{
 
    public static bool CanArrange(int[] arr, int k)
    {
        // Array to keep track of remainder counts
        int[] remainderCounts = new int[k];

        foreach (int number in arr)
        {
            // Calculate remainders and count their occurrences
            remainderCounts[FindRemainder(number, k)]++;
        }
        // Check the conditions for pairing
        for (int i = 1; i < k; ++i)
        {
            if (remainderCounts[i] != remainderCounts[k - i])
            {
                return false;
            }
        }
        // Count of remainder 0 must be even
        if (remainderCounts[0] % 2 != 0)
        {
            return false;
        }

        return true;
    }

    public static int FindRemainder(int x, int k)
    {
        return ((x % k) + k) % k;// Remove negative by adding k for negative remainder
    }
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 14};
        int k = 7;
        bool result = CanArrange(arr, k);
        Console.WriteLine(result); 
    }
}
