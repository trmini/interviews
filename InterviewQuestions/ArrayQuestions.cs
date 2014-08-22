using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public static class ArrayQuestions
    {
        /// <summary>
        /// Given two sorted arrays in which the second array has just enough spaces at the end to hold the first array.
        /// Write a merge function to merge the first array to the second array so that the second array remains sorted.
        /// </summary>
        /// <param name="arrayA">The first sorted array</param>
        /// <param name="arrayB">The second sorted array with spaces at the end</param>
        /// <returns>Combined sorted array</returns>
        public static int [] MergeTwoSortedArray(int[] arrayA, int[] arrayB)
        {
            if (arrayA == null || arrayB == null)
            {
                throw new ArgumentNullException();
            }

            int indexA = arrayA.Length - 1;
            int endOfB = arrayB.Length - 1;
            int indexB = endOfB - indexA - 1;

            if (endOfB < indexA)
            {
                throw new ArgumentException("Array B doesn't have enough spaces for array A");
            }

            while (indexA >= 0 && indexB >= 0)
            {
                arrayB[endOfB--] = (arrayA[indexA] >= arrayB[indexB]) ? arrayA[indexA--] : arrayB[indexB--];
            }

            while (indexA >= 0)
            {
                arrayB[endOfB--] = arrayA[indexA--];
            }

            return arrayB;
        }
    }
}
