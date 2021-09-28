using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumSortApi.Models
{
    public class NumberArrayContainer
    {
        public IEnumerable<int> Numbers { get; set; }

        public IEnumerable<int> SortedNumbers => MyMergeSorter.Sort(Numbers);

        // TODO: Why isn't this set autimatically? Fix.
        public IEnumerable<int> FiledData
        {
            set => NumberArrayFileIO.SaveList(SortedNumbers);
            get => NumberArrayFileIO.LoadList();
        }
    }
}
