using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace NumSortApi.UnitTests
{
    public class TestSort
    {
        [Fact]
        public void CanMergeSortListOfUniqueNumbers()
        {
            var inputArray = new List<int>() { 4, 8, 3, 6, 5, 1, 9, 7, 2, 0 };
            var expected = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            var actual = MyMergeSorter.Sort(inputArray);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanMergeSortListOfSimilarNumbers()
        {
            var inputArray = new List<int>() { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 };
            var expected = new List<int>() { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3 };

            var actual = MyMergeSorter.Sort(inputArray);

            Assert.Equal(expected, actual);
        }
    }
}
