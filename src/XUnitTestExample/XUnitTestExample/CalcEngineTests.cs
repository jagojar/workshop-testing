using System;
using Xunit;

namespace XUnitTestExample
{
    public class CalcEngineTests
    {
        [Fact]
        public void Add_8_plus_4_Result_Is_12()
        {
            //Arrange
            var calc = new CalcEngine();

            //Act
            var result = calc.Add(8, 4);

            //Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void Multiply_8_plus_4_Result_Is_32()
        {
            //Arrange
            var calc = new CalcEngine();

            //Act
            var result = calc.Multiply(8, 4);

            //Assert
            Assert.Equal(32, result);
        }

        [Fact]
        public void Divide_8_plus_4_Result_Is_2()
        {
            //Arrange
            var calc = new CalcEngine();

            //Act
            var result = calc.Divide(8, 4);

            //Assert
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(2, 4)]
        [InlineData(4, 8)]
        public void Multiply_Serveral_Values(int value, int resultValue)
        {
            //Arrange
            var calc = new CalcEngine();

            //Act
            var result = calc.MultiplyBy2(value);

            //Assert
            Assert.Equal(result, resultValue);
        }

    }
}
