public class MemoFib
{
    private Dictionary<int, int> memo = new Dictionary<int, int>(); // n, result

    // Bottom-Up Iterative Approach
    // Time: O(n), Space: O(1) ... look ma, no data structures
    public int iterativeFib(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("meow");
        }
        else if (n == 0 || n == 1)
        {
            return n;
        }
        int prevprev = 0;
        int prev = 1;
        int current = 0;
        for (int i = 1; i < n; i++)
        {
            current = prev + prevprev;
            prevprev = prev;
            prev = current;
        }
        return current;
    }

    // Memoization Approach
    // Time: O(n) thanks to memoization, Space: O(n) ... due to extra memoization space via dictionary
    public int recursiveFib(int n)
    {
        if (n == 0 || n == 1)
        {
            return n;
        }
        if (memo.ContainsKey(n))
        {
            return memo[n];
        }
        else
        {
            int result = recursiveFib(n - 1) + recursiveFib(n - 2);
            memo.Add(n, result);
            return result;
        }
    }
}