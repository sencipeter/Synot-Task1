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
        public void ServiceWithException_FindExtraNumberTests(int[] numbers, int expected)
        {            
            IService service = new ServiceWithException();           
            var result = service.FindExtraNumber(numbers);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1, 8, 7, -5 })]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1, 8, 7, -5, 8 })]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1 })]
        public void ServiceWithException_FindExtraNumberTests_ArgumentException(int[] numbers)
        {
            IService service = new ServiceWithException();            
            Assert.Throws<ArgumentException>(() => service.FindExtraNumber(numbers));
        }

        [Theory]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1, 8, 7 }, -5)]                
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1 }, -5)]
        public void ServiceWithFirstNumber_FindExtraNumberTests(int[] numbers, int expected)
        {
            IService service = new ServiceWithFirstNumber();
            var result = service.FindExtraNumber(numbers);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1, 8, 7, -5 })]
        [InlineData(new int[] { 6, 9, 2, -1, -5, 4, 4, 9, 2, 0, 1, 0, 6, 7, 1, 8, -1, 8, 7, -5, 8 })]
        public void ServiceWithFirstNumber_FindExtraNumberTests_ArgumentException_NumberNotPresent(int[] numbers)
        {
            IService service = new ServiceWithFirstNumber();
            Assert.Throws<ArgumentException>(() => service.FindExtraNumber(numbers));
        }
    }
}