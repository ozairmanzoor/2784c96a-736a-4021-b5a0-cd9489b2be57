using SubsequenceService;

internal class Program
{

    private static void Main(string[] args)
    {
        var generator = new SubsequenceGenerator();
        
        var longestSubsequence = generator.FindLongestIncreasingSubsequence(string.Join(" ", args));
        
        Console.WriteLine(longestSubsequence);
    }
}