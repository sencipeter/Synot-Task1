using Synot.Task1;
using Synot.Task1.Intefraces;

namespace Synot.Task.Tests
{
    public class ServiceTests
    {
        [Theory]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1, 8, 7},-5)]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, 8, 7, -5 }, -1)]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 8, -1, 8, 7, -5, 8 }, 1)]
        [InlineData(new int[] { 6, 9, 2, -1, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, -1 }, 7)]
        public void FindExtraNumberTests(int[] numbers, int expected)
        {            
            IService service = new Service();           
            var result = service.FindExtraNumber(numbers);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1, 8, 7, -5 })]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1, 8, 7, -5, 8 })]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1 })]
        public void FindExtraNumberTests_ArgumentException(int[] numbers)
        {
            IService service = new Service();            
            Assert.Throws<ArgumentException>(() => service.FindExtraNumber(numbers));
        }
    }
}