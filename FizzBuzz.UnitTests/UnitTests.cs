namespace FizzBuzz.UnitTests
{
    public class UnitTests
    {
        private FizzBuzzService _fizzBuzz;

        public UnitTests()
        {
            _fizzBuzz = new FizzBuzzService();
        }

        [Fact]
        public void NumberTest1()
        {
            string result = _fizzBuzz.GetFizzBuzzValue(1);

            Assert.Equal("1", result);
        }

        [Fact]
        public void NumberTest2()
        {
            string result = _fizzBuzz.GetFizzBuzzValue(97);

            Assert.Equal("97", result);
        }

        [Fact]
        public void FizzTest1()
        {
            string result = _fizzBuzz.GetFizzBuzzValue(3);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void FizzTest2()
        {
            string result = _fizzBuzz.GetFizzBuzzValue(27);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void BuzzTest1()
        {
            string result = _fizzBuzz.GetFizzBuzzValue(5);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void BuzzTest2()
        {
            string result = _fizzBuzz.GetFizzBuzzValue(35);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void FizzBuzzTest1()
        {
            string result = _fizzBuzz.GetFizzBuzzValue(15);

            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void FizzBuzzTest2()
        {
            string result = _fizzBuzz.GetFizzBuzzValue(60);

            Assert.Equal("FizzBuzz", result);
        }
    }
}