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
            
            int result = numbers.Split(',').Select(int.Parse).ToArray().Sum();
            
            return result;
                
        }
    }
}
