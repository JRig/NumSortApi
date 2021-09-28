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
        public string Get()
        {
            var response = JsonSerializer.Serialize(NumberArrayFileIO.LoadList());
            return response;
        }

        [HttpPost]
        public IEnumerable<int> Post([FromBody] int[] numbers)
        {
            var response = new NumberArrayContainer() { Numbers = numbers };
            NumberArrayFileIO.SaveList(response.SortedNumbers);
            return response.SortedNumbers;
        }
    }
}
