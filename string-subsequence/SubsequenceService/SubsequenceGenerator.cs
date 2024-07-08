
namespace SubsequenceService
{
    public class SubsequenceGenerator : ISubsequenceGenerator
    {
        public int FindLongestIncreasingSubsequence(string numbers)
        {
            var lisOfNumber = numbers.Split(' ');
            
            if(lisOfNumber.Length == 0 )
                return 0;

            return 1;
          
        }
    }
}
