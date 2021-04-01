using System;
using Xunit;

namespace test.xunit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("hi","hi");
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("a","hi");
        }

        [Fact]
        public void Test3()
        {
            Assert.True(false);
        }
    }
}
