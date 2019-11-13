using System;
using Xunit;
using getindex;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 2;
            List<int> testList = new List<int> { a };
            int expectedResult = 0;
            Assert.Equal(Program.GetIndex(a, testList), expectedResult);
        }

        [Fact]
        public void test2()
        {
            List<int> mylist = new List<int>();
            Assert.Equal(Program.GetIndex(0, mylist), -1);
        }
    }
}
