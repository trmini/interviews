using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using InterviewQuestions;

namespace InterviewUnitTests
{
    [TestClass]
    public class ArrayUnitTests
    {
        [TestMethod]
        public void MergeTwoSortedArray_BasicTest()
        {
            int[] result = ArrayQuestions.MergeTwoSortedArray(new int[] {1,2,3}, new int[] {3,5,7,0,0,0});
        }
    }
}
