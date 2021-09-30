using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    public class SimpleArrayExercises
    {
        public static CountVowels(string text)
        {
        int countVowels = 0;
         string str = str.ToUpper();
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str.(i); 
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                countVowels++;
            }
        }
        return countVowels;
        }
        public static int CountEvenNumbers(int[] numberArray)
        {
            return 0;
        }
        public static int ReverseArrayOrder(int[] numberArray) 
        {
            return 0;
        }
    }
}
