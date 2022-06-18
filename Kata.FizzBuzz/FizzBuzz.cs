namespace Kata.FizzBuzz
{
    public static class FizzBuzz
    {
        public static string PrintNumber()
        {
            var number = string.Empty;
            for (int i = 0; i < 100; i++)
                number += IsFizz(i) ? " " + "Fizz" : (IsBuzz(i) ?  " " + "Buzz" : " " + i);
                

            return number.Trim();
        }

        public static bool IsFizz(int n)
        {
            return n % 3 == 0;
        }

        public static bool IsBuzz(int n)
        {
            return n % 5 == 0;
        }
        
    }
}