using Synot.Task1.Intefraces;

namespace Synot.Task1
{
    public class ServiceWithFirstNumber : IService
    {
        /// <inheritdoc/>
        /// 
        public int FindExtraNumber(int[] numbers)
        {            
            var groups = numbers.GroupBy(number => number).OrderBy(o=>o.Count());
            if (groups.Any(g => g.Count() == 1))
                return groups.Where(g=>g.Count()==1).First().First();
            else
                throw new ArgumentException("No number in the list is present once.");
            
        }
    }
}