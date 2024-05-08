using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dsa_stack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StackController : ControllerBase
    {
        [HttpGet("stack")]
        public Dictionary<string, int> GetStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Pop();

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs.Add("count", stack.Count);
            keyValuePairs.Add("peek", stack.Peek());
            return keyValuePairs;
        }
    }
}
