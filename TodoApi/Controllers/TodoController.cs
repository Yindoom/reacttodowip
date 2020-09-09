using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Entities;
using Core.Service;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        private readonly ITodoService _service;

        public TodoController(ILogger<TodoController> logger, ITodoService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> Get()
        {
            return Ok(_service.ReadAll());
        }

        [HttpPost]
        public ActionResult<Todo> Post([FromBody] Todo body)
        {
            return Ok(_service.AddTodo(body));
        }

        [HttpPut("{id}")]
        public ActionResult<Todo> Put(int id, [FromBody] Todo body)
        {
            return Ok(_service.UpdateTodo(id, body));
        }

        [HttpDelete("{id}")]
        public ActionResult<int> Delete(int id)
        {
            return Ok(_service.DeleteTodo(id));
        }
    }
}
