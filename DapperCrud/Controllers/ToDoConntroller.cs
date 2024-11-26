using DapperCrud.Interface;
using DapperCrud.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoConntroller : ControllerBase
    {
        private readonly IDapperService _dapperService;
        public ToDoConntroller(IDapperService dapperService)
        {
            _dapperService = dapperService;
        }

        // GET: api/<ToDoConntroller>
        [HttpGet]
        public Task<List<ToDo>> Get()
        {
            var tasks = _dapperService.GetAll();
            return tasks;
        }

        // GET api/<ToDoConntroller>/5
        [HttpGet("{id}")]
        public async Task<ToDo> Get(int id)
        {
            var task = await _dapperService.GetTaskById(id);
            return task;
        }

        // POST api/<ToDoConntroller>
        [HttpPost]
        public async Task<string> Post([FromBody] ToDo toDo)
        {
          var task = await _dapperService.CreateTask(toDo);
            return task;

        }

        // PUT api/<ToDoConntroller>/5
        [HttpPut("{id}")]
        public async Task<string> Put(int id, [FromBody] ToDo toDo)
        {
            var task = await _dapperService.UpdateTask(toDo);
            return task;
        }

        // DELETE api/<ToDoConntroller>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            var response = await _dapperService.DeleteTask(id);
            return response;
        }
    }
}
