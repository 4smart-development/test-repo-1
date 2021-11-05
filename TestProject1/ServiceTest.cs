using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class ServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = Service.Sum(1, 2);

            Assert.Equal(3, result);
        }
    }
}
