using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;

namespace dsa_stack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StackController : ControllerBase
    {
        [HttpGet("stack")]
        public Dictionary<string, object> GetStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(3);
            stack.Push(3);
            stack.Pop();

            List<int> list = stack.ToList();
            

            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            keyValuePairs.Add("count", stack.Count);
            keyValuePairs.Add("peek", stack.Peek());
            keyValuePairs.Add("list", list);
            return keyValuePairs;
        }

        [HttpGet("sortStack")]
        public List<int> sortStack()
        {
            int[] nums = { 1, 2, 4, 5, 63, 1, 5, 3, 2 };
            Stack<int> stack = new Stack<int>();
            foreach(int num in nums)
            {
                stack.Push(num);
            }
            Stack<int> storage = new Stack<int>();
            while( stack.Count >0)
            {
                int tmp = stack.Pop();
                while(storage.Count > 0  && storage.Peek() < tmp) { 
                
                   stack.Push(storage.Pop());
                }
                storage.Push(tmp);
            }
            List<int> list = storage.ToList();
            return list;
        }
    }
}
