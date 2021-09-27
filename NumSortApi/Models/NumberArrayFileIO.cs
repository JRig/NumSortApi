using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumSortApi.Models
{
    public static class NumberArrayFileIO
    {
        public static void SaveList(IEnumerable<int> numbers)
        {
            System.IO.File.WriteAllLines(
            System.IO.Directory.GetCurrentDirectory() + "\\NumSortApi\\LatestFile.txt",
            numbers.Select(num => num.ToString()));
        }

        public static IEnumerable<int> LoadList()
        {
            try
            {
                var numbersFromFile = System.IO.File.ReadAllLines(
                    System.IO.Directory.GetCurrentDirectory() + "\\NumSortApi\\LatestFile.txt"
                ).Select(str => int.Parse(str));
                return numbersFromFile;
            }
            catch (Exception)
            {
                return Array.Empty<int>();            
            }
        }
    }
}
