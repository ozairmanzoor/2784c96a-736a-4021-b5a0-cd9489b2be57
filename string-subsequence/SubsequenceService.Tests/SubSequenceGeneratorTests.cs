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
    public void FindLongestIncreasingSubsequence_WhenInputStringIsEmpty_ShouldReturn0()
    {
        var longIncreasingSubsequence = _generator.FindLongestIncreasingSubsequence(string.Empty);

        Assert.Equal(0, longIncreasingSubsequence);
    }

    /// <summary>
    /// When input string had one number
    /// </summary>
    [Theory]
    [InlineData("1", 1)]
    [InlineData("2000", 1)]
    public void FindLongestIncreasingSubsequence_WhenInputStringHasOneNumber_ShouldReturn1(string numbers, int expectedResult)
    {
        var longIncreasingSubsequence = _generator.FindLongestIncreasingSubsequence(numbers);

        Assert.Equal(expectedResult, longIncreasingSubsequence);
    }
}