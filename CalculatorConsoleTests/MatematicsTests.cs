using CalculatorConsole;

namespace CalculatorConsoleTests
{
    public class MatematicsTests
    {
        [Fact]
        public void Matematics_Add_Metod_Two_Numbers_Is_Equal()
        {
            //Arrange
            double a = 10;
            double b = 20;
            double expectedResult = 30;

            //Act
            var result = Matematics.Add(a, b);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        
        [Theory]
        [InlineData(7, true)]
        [InlineData(-9, false)]
        [InlineData(78, true)]
        [InlineData(4, true)]
        [InlineData(-17, false)]
        [InlineData(100, true)]
        [InlineData(-77, false)]
        [InlineData(8, true)]
        public void IsValidate_Numbers_More_Than_Zero(int x,  bool expectedResult)
        {
            //act
            var result = Matematics.IsValidate(x);
            
            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test_Divide_Metod_For_Exception()
        {
            //arrange
            double x = 3; double y = 0;

            //act
            Action result = () => Matematics.Divide(x, y);

            //assert
            //Assert.Throws<DivideByZeroException>(result);

            var message = Assert.Throws<DivideByZeroException>(result);
            Assert.Equal(message.Message, "y 0 ga teng bo'lishi mumkin emas.");
        }

        [Fact]
        public void Matematics_Multiply_Two_Numbers_Is_Equal()
        {
            //arrange
            double a = 3;
            double b = 8;
            double expectedResult = 24;

            //act
            var result = Matematics.Multiply(a, b);

            //assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Matematics_Subtract_Two_Numbers_Is_Equal()
        {
            //arrange
            double a = 77;
            double b = 88;
            double expectedResult = -11;

            //act
            var result = Matematics.Subtract(a, b);

            //assert
            Assert.Equal(expectedResult, result);
        }

    }
}