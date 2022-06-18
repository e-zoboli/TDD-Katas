namespace Kata.FizzBuzz
{
    public static class FizzBuzz
    {
        public static string PrintNumber(int n)
        {
            var number = string.Empty;
            for (int i = 1; i <= n; i++)
                number += IsFizzBuzz(i) ? " " + "FizzBuzz" : IsFizz(i) ? " " + "Fizz" : IsBuzz(i) ?  " " + "Buzz" : " " + i;
                

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
        
        public static bool IsFizzBuzz(int n)
        {
            return IsFizz(n) && IsBuzz(n);
        }
    }
}