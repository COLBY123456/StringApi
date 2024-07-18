using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StringApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return BadRequest("Input string cannot be null or empty.");
            }

            var reversedString = ReverseString(input);
            var isPalindrome = IsPalindrome(input);

            var result = new
            {
                ReversedString = reversedString,
                IsPalindrome = isPalindrome
            };

            return Ok(result);
        }

        private string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private bool IsPalindrome(string input)
        {
            var reversedString = ReverseString(input);
            return string.Equals(input, reversedString, StringComparison.OrdinalIgnoreCase);
        }
    }
}
