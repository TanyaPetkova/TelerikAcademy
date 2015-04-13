namespace LongestSequenceFinder.Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using LongestSubsequenceFinder;

    [TestClass]
    public class FindMaximalSequenceTests
    {
        [TestMethod]
        public void GetSingleLongestSequence()
        {
            List<int> sequence = new List<int>() {2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            List<List<int>> output = Program.FindLongestSubsequences(sequence);
            List<int> expectedOutput = new List<int>() { 2, 2, 2 };
            
            CollectionAssert.AreEqual(expectedOutput, output[0]);
        }

        [TestMethod]
        public void GetTwoLongestSequences()
        {
            List<int> sequence = new List<int>() { 2, 1, 2, 2, 2, 3, 2, 2, 2, 1 };
            List<List<int>> output = Program.FindLongestSubsequences(sequence);
            List<int> expectedOutput = new List<int>() { 2, 2, 2 };

            CollectionAssert.AreEqual(expectedOutput, output[0]);
            CollectionAssert.AreEqual(expectedOutput, output[1]);
        }

        [TestMethod]
        public void GetTwoDiffrentLongestSequence()
        {
            List<int> sequence = new List<int>() { 2, 1, 2, 2, 2, 3, 1, 1, 1, 2 };
            List<List<int>> output = Program.FindLongestSubsequences(sequence);
            List<int> expectedOutput = new List<int>() { 2, 2, 2 };

            CollectionAssert.AreEqual(expectedOutput, output[0]);

            expectedOutput = new List<int>() { 1, 1, 1 };
            CollectionAssert.AreEqual(expectedOutput, output[1]);
        }

        [TestMethod]
        public void GetFewLongestSequenceWithSingleNumbers()
        {
            List<int> sequence = new List<int>() { 1, 2, 3, 4, 5 };
            List<List<int>> output = Program.FindLongestSubsequences(sequence);
            List<int> expectedOutput = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                expectedOutput.Add(i + 1);
                CollectionAssert.AreEqual(expectedOutput, output[i]);
                expectedOutput.Clear();
            }
        }
    }
}
