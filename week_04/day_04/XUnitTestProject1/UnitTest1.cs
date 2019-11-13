using System;
using Xunit;
using sum;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test2 ()
        {
            SumOperations sumOperationsTwo = new SumOperations();
            List<int> listOne = new List<int> { 2, 2, 0, 4 };
            Assert.Equal(8, sumOperationsTwo.Sum(listOne));
        }
        [Fact]
        public void Test3()
        {
            SumOperations sumOperationsTwo = new SumOperations();
            List<int> listOne = new List<int> { 8};
            Assert.Equal(8, sumOperationsTwo.Sum(listOne));
        }

        [Theory]
        [InlineData(new int[4] {2, 2, 0, 4})]
        public void Test1 (int[] numbers)
        {
            var list = new List<int>(numbers);
            SumOperations sumOperations = new SumOperations();
            Console.WriteLine(sumOperations.Sum(list));
            Assert.Equal(8, sumOperations.Sum(list));
        }

        [Theory]
        [InlineData(new int[] {})]
        public void Test5(int[] numbers)
        {
            var list = new List<int>(numbers);
           
            
            SumOperations sumOperations = new SumOperations();
            Assert.Equal(0 ,sumOperations.Sum(null)); 
        }
    }
}
