﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.KarateChop
{
    public static class KarateChop
    {
        public static int Search(int n, int[] numbers)
        {
            //Simple iteration
            //int index = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == n)
            //    {
            //        index = i;
            //        return index;
            //    }
            //}
            //return -1;

            //IndexOf method
            //return Array.IndexOf(arr, n);

            // Binary Search
            int min = 0;
            int max = numbers.Length - 1;
            while(min <= max)
            {
                int middle = (min + max) / 2;
                if (numbers[middle] == n)
                    return middle;
                else if (numbers[middle] > n)
                    max = middle - 1;
                else 
                    min = middle + 1;             
            }
            return -1;
            


        }
    }
}
