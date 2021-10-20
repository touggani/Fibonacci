using System.Collections.Generic;
using System.Threading.Tasks;
using Fibonacci;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController: ControllerBase
    {
        private readonly Fibo _fibo;

        public FibonacciController(Fibo fibo)
        {
            _fibo = fibo;
        }

        [HttpGet(Name = "{number}")]
        public async Task<List<long>> Get(string number)
        {
            return await _fibo.ExecuteAsync(new[] {number});
        }
    }
} 