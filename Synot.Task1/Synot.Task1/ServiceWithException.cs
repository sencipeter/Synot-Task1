using Synot.Task1.Intefraces;

namespace Synot.Task1
{
    public class ServiceWithException : IService
    {
        /// <inheritdoc/>
        /// 
        public int FindExtraNumber(int[] numbers)
        {            
            var groups = numbers.GroupBy(number => number).OrderBy(o=>o.Count());
            if (groups.Where(g => g.Count() == 1).Count() != 1)
                throw new ArgumentException("Criteria not met: Every number is present twice, only one number in the list is present once.");
            return groups.First().First();
        }
    }
}