namespace LeetCode;

/// <summary>
///     https://leetcode.com/problems/palindrome-number/
/// </summary>
public static class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        var input = x.ToString().ToCharArray();

        for (int i = 0; i < input.Length; i++)
        {
            if (i > input.Length/2)
            {
                return true;
            }
            if (input[i] != input[input.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsPalindromV2(int x)
    {
        int r = 0, c = x;
        while (c > 0)
        {
            r = r * 10 + c % 10;
            c /= 10;
        }
        return r == x; 
    }
}