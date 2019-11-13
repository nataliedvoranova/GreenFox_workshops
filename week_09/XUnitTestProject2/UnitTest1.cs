using System;
using Xunit;
using anagramtests;
using System.Collections.Generic;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var input = new List<string> { "racecar", "arcecar" };

            bool result = Program.CheckAnagram(input);

            bool expectedresult = true;

            Assert.Equal(expectedresult,result);

      

        }
    }
}
