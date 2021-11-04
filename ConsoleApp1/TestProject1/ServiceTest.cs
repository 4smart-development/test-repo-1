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
            var service = new Service();

            var result = service.Sum(1, 2);

            Assert.Equal(3, result);
        }
    }
}
