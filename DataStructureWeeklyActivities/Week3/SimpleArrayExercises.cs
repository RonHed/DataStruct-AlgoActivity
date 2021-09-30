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
        public static int CountEvenNumbers(int[] numberArray, int[] numberArraySize)
        {
            int countEven = 0;
 
            for (int i = 0; i < numberArraySize.Length; i++) {
                if ((numberArray[i] % 2) == 0)
                countEven++;
            }
 
            return countEven;
        }
        public static int ReverseArrayOrder(int[] numberArray) 
        {
            return 0;
        }
    }
}
