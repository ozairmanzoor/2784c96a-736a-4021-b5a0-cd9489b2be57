
namespace SubsequenceService
{
    public class SubsequenceGenerator : ISubsequenceGenerator
    {
        public string FindLongestIncreasingSubsequence(string numbers)
        {
            if(string.IsNullOrWhiteSpace(numbers))
                return string.Empty;

            var result = numbers.Split(' ');
            if(result.Length == 1 ) 
                return result[0];


            return numbers;
        }
    }
}
