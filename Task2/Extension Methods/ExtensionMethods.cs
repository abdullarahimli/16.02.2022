using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Extension
{
    static class ExtensionMethods
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static int [] methodGetValueIndexes(this int [] a, int b)
        {
            int [] array = { };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = i;

                }
            }
            return array;
        }
    }
}
