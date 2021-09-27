using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumSortApi
{
    public class MyMergeSorter
    {
        public static IEnumerable<int> Sort(IEnumerable<int> numbers)
        {
            var data = numbers.ToList();
            return Divide(data);
        }

        private static List<int> Divide(List<int> numbers) 
        {
            var count = numbers.Count();
            if (count > 2)
            {
                var leftList = numbers.GetRange(0, count / 2);
                var leftSide = Divide(leftList);
                var rightList = numbers.GetRange(count / 2, count / 2 + count % 2);
                var rightSide = Divide(rightList);
                var merged = (List<int>)Merge(leftSide, rightSide);
                return merged;
            }
            else if (count == 2)
            {
                var leftSide = numbers[0];
                var rightSide = numbers[1];
                return leftSide >= rightSide ? new List<int> { rightSide, leftSide } : new List<int> { leftSide, rightSide };
            }
            else
            {
                return numbers;
            }
        }

        private static IEnumerable<int> Merge(List<int> leftSide, List<int> rightSide)
        {
            List<int> sortedList = new List<int>();
            while (leftSide.Any() && rightSide.Any())
            {
                if (leftSide[0] > rightSide[0])
                {
                    sortedList.Add(rightSide[0]);
                    rightSide.RemoveAt(0);
                }
                else
                {
                    sortedList.Add(leftSide[0]);
                    leftSide.RemoveAt(0);
                }
            }
            if (leftSide.Any())
            {
                sortedList.AddRange(leftSide);
            }
            else
            {
                sortedList.AddRange(rightSide);
            }
            return sortedList;
        }
    }
}
