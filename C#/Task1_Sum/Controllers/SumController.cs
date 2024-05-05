using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Task1_Sum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SumController : ControllerBase
    {
        
        [HttpPost(Name ="task")]

       public IActionResult sum(int a, int b)
        {
            int c = a + b;
            return Ok(c);
        }

        [HttpPost("reverse",Name = "reverse")]

        public IActionResult reverse(string str1)
        {
            string temp="";
            for (int i = 1; i<=str1.Length; i++)
            {
                temp += str1[str1.Length-i];
            }
            
            return Ok(temp);
        }

    }
}
