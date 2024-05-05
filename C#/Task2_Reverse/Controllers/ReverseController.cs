using Microsoft.AspNetCore.Mvc;

namespace Task2_Reverse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseController : ControllerBase
    {
        [HttpPost("reverse", Name = "reverse")]

        public IActionResult reverse(string str1)
        {
            string temp = "";
            for (int i = 1; i <= str1.Length; i++)
            {
                temp += str1[str1.Length - i];
            }

            return Ok(temp);
        }
    }
}
