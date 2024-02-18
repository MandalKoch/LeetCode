namespace LeetCode;

public class PalindromeNumberTests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    [InlineData(0, true)]
    public void PalindromeTests(int x, bool assert)
    {
        var answer = PalindromeNumber.IsPalindrome(x);
        answer.Should().Be(assert);
    }
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    [InlineData(0, true)]
    public void PalindromeV2Tests(int x, bool assert)
    {
        var answer = PalindromeNumber.IsPalindromV2(x);
        answer.Should().Be(assert);
    }
}