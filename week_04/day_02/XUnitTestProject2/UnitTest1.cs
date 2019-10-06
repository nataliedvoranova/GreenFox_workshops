using System;
using Xunit;
using ConsoleApp3;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void IsAppleAdded()
        {
            Apples apple = new Apples();
  
            Assert.Equal("apple", apple.GetApple());
        }

    }
}
