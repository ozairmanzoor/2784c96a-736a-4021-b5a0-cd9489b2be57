
namespace SubsequenceService
{
    public class SubsequenceGenerator : ISubsequenceGenerator
    {
        static int max_ref;

        public string FindLongestIncreasingSubsequence(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var numbers = input.Split(' ').Select(x => int.Parse(x)).ToArray();
            if(numbers.Length == 1 ) 
                return numbers[0].ToString();

            var sequenceStore = new List<string>();
            
            for(int i =  0; i < numbers.Length; i++)
            {
                var previous = numbers[i];
                var subsequence = new List<string>();
                for (int j = i+1; j<numbers.Length;j++)
                {
                    var next = numbers[j];
                    if (next > previous)
                    {
                        subsequence.Add(next.ToString());
                        previous = next;
                    }
                }
                sequenceStore.Add($"{i} {string.Join(" ",subsequence)}");
            }

            //var memebers = new List<int>();
            //foreach( var subsequence in sequenceStore )
            //{
            //    memebers.Add(subsequence.Split(' ').Length);

            //}
            var memebers = sequenceStore.Select(seq => seq.Split(' ').Length).ToList();
            var index = memebers.IndexOf(memebers.Max());
            return sequenceStore[index];
        }
    }
}
