using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.StringCalculator
{
    public static class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            if (numbers.Length == 1)
            {
                int.TryParse(numbers, out int singleNum);
                return singleNum;
            }

            var otherDelim = !Char.IsDigit(numbers[2]) ? numbers[2] : ' ';
            int[] onlyIntArray = numbers
                .Split(',', '\n', otherDelim)
                .Where(x => int.TryParse(x, out int y))
                .Select(int.Parse)
                .ToArray();

            if(!onlyIntArray.Any(x => x < 0))
            {
                int result = onlyIntArray
                    .Where(x => x <= 1000)
                    .ToArray()
                    .Sum();
                return result;
            }
            string[] arrWithNegative = onlyIntArray.Where(x => x < 0).Select(x => x.ToString()).ToArray();

            throw new ArgumentException("negatives not allowed: " + string.Join(",", arrWithNegative));
            
                
        }
    }
}
