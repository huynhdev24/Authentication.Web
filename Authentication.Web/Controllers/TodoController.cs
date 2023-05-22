using Authentication.Domain.Entities;
using Authentication.Infrastructure.Unitofwork;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Web.Controllers
{
    [Authorize]
    [Route("api/todo")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IUnitofwork unitofWork;

        public TodoController(IUnitofwork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var todos = this.unitofWork.Todo.All().ToList();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodoById(int id)
        {
            var todo = this.unitofWork.Todo.Get(id);
            return Ok(todo);
        }

        [HttpPost]
        public IActionResult CreateTodo([FromBody] Todo todo)
        {
            if (todo == null)
            {
                return BadRequest("Todo object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            this.unitofWork.Todo.Add(todo);
            this.unitofWork.SaveChanges();
            return Ok(todo);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTodo(int id, [FromBody] Todo todo)
        {
            var todoDelete = this.unitofWork.Todo.Get(id);
            if (todoDelete == null)
            {
                return NotFound();
            }

            this.unitofWork.Todo.Delete(todo);
            this.unitofWork.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTodo(int id, [FromBody] Todo todo)
        {
            if (todo == null)
            {
                return BadRequest("Todo object is null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid model object");
            }

            var todoEntity = this.unitofWork.Todo.Get(id);
            if (todoEntity == null)
            {
                return NotFound();
            }

            this.unitofWork.Todo.Update(todo);
            this.unitofWork.SaveChanges();
            return NoContent();
        }
    }
}
