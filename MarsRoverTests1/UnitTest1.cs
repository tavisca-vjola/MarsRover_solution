using MarsRover;
using System;
using Xunit;

namespace MarsRoverTests1
{
    public class UnitTest1
    {

        [Fact]
        public void test_simple_rotation()
        {
            Rover r = new Rover();
            r.GetInstruction("1 2 N");
            string actual = r.CommandProccessor("RM");

            Assert.Equal("2 3 NE", actual);

        }

      
    }
}
