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
            string stringifiedNumbers = string.Join(",", numbers);
            File.WriteAllText(
                Directory.GetCurrentDirectory() + "\\LatestFile.txt",
                stringifiedNumbers);
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
