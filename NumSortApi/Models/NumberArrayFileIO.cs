using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NumSortApi.Models
{
    public static class NumberArrayFileIO
    {
        public static void SaveList(IEnumerable<int> numbers)
        {
            string test = String.Join(",", numbers);
            File.WriteAllText(
                Directory.GetCurrentDirectory() + "\\LatestFile.txt",
                test);
        }

        public static IEnumerable<int> LoadList()
        {
            try
            {
                var numbersFromFile = System.IO.File.ReadAllText(
                    Directory.GetCurrentDirectory() + "\\LatestFile.txt"
                ).Split(",").Select(int.Parse);

                return numbersFromFile;
            }
            catch (Exception)
            {
                return Array.Empty<int>();            
            }
        }
    }
}
