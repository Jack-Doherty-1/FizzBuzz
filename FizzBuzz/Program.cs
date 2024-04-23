namespace FizzBuzz
{
    public class Program()
    {
        static FizzBuzzService _fizzBuzz = new FizzBuzzService();

        public static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(_fizzBuzz.GetFizzBuzzValue(i));
            }
        }
    }

}