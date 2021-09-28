using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NumSortApi.Models;
using System.Text.Json;

namespace NumSortApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class SortingController : ControllerBase
    {
        [HttpGet]
        public string GetLatestSortedNumbers()
        {
            var response = JsonSerializer.Serialize(NumberArrayFileIO.LoadList());
            return response;
        }

        [HttpPost]
        public IEnumerable<int> PostNewNumbersToBeSorted([FromBody] int[] numbers)
        {
            var response = new NumberArrayContainer() { Numbers = numbers };
            
            // The numbers are saved to file manually here,
            // because it didn't work in the NumberArrayContainer.
            // TODO: Remove when NumberArrayContainer saves to file.
            NumberArrayFileIO.SaveList(response.SortedNumbers);
            
            return response.SortedNumbers;
        }
    }
}
