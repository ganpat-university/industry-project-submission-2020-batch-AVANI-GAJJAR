using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace MyOwnAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        // my code 
       
            [HttpGet("avani",Name ="avani")]
            public IActionResult avani()
            {
                // Your function logic here
                return Ok("Hello... \nAvani Here!");
            }
            [HttpGet("avani2", Name = "avani2")]
            public IEnumerable<string> avani2()
            {
                // Your function logic here
                return new string[] { "Avani", "Gajjar" };
            }
            [HttpGet("avani3", Name = "avani3")]
            public IEnumerable<Int32> avani3()
            {
                // Your function logic here
                return new int[] { 23,32,11};
            }

            [HttpPost("avani4", Name = "avani4")]
            public IActionResult Post(Int32 age)
            {
                // Your function logic here
                if (age < 0)
                {
                   return BadRequest("Invalid Input");
                }
                return Ok(age);
            }

            [HttpPut("newput", Name = "newput")]
            public IActionResult Put(Int32 age)
            {
                // Your function logic here
                if (age < 0)
                {
                    return BadRequest("Invalid Input");
                }
                return Ok(age);
            }

           
            private List<Item> dataStore = new List<Item>
            {
                // Initialize your list with some data
                new Item { Id = 1, Name = "Item 1" },
                new Item { Id = 2, Name = "Item 2" },
                new Item { Id = 3, Name = "Item 3" },
            };
        [HttpDelete("delete/{id}", Name = "DeleteItem")]
        public IActionResult DeleteItem(int id)
        {
            // Your function logic here
            // 'id' parameter represents the identifier of the item to be deleted

            var itemToRemove = dataStore.FirstOrDefault(item => item.Id == id);

            if (itemToRemove == null)
            {
                return NotFound($"Item with ID {id} not found.");
            }

            dataStore.Remove(itemToRemove);

            return Ok($"Item with ID {id} has been deleted.");
        }

    }
}
