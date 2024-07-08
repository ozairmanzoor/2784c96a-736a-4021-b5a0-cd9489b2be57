namespace SubsequenceService.Tests;

public class SubSequenceGeneratorTests
{
    private readonly ISubsequenceGenerator _generator;
    public SubSequenceGeneratorTests()
    {
        _generator = new SubsequenceGenerator();
    }

    /// <summary>
    /// When input string is empty
    /// </summary>
    [Fact]
    public void FindLongestIncreasingSubsequence_WhenInputStringIsEmpty_ShouldReturnEmptyString()
    {
        var longIncreasingSubsequence = _generator.FindLongestIncreasingSubsequence(string.Empty);

        Assert.Empty(longIncreasingSubsequence);
    }

    /// <summary>
    /// When input string had one number
    /// </summary>
    [Theory]
    [InlineData("1", "1")]
    [InlineData("2000", "2000")]
    public void FindLongestIncreasingSubsequence_WhenInputStringHasOneNumber_ShouldReturn1(string numbers, string expectedResult)
    {
        var longIncreasingSubsequence = _generator.FindLongestIncreasingSubsequence(numbers);

        Assert.Equal(expectedResult, longIncreasingSubsequence);
    }

    [Theory]
    [InlineData("6 1 5 9 2", "1 5 9")]
    public void FindLongestIncreasingSubsequence_WhenInputStringHasOneNumber_ShouldReturnxxx(string numbers, string expectedResult)
    {
        var longIncreasingSubsequence = _generator.FindLongestIncreasingSubsequence(numbers);

        Assert.Equal(expectedResult, longIncreasingSubsequence);
    }
}