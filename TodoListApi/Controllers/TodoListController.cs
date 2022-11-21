using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListApi.Data;
using TodoListApi.Models;

namespace TodoListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TodoListController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetTasks()
        {
            return Ok(await _context.todoLists.ToListAsync());
        }

        [HttpPost]
        public IActionResult AddTasks(TodoList list)
        {
            
             _context.Add(list);
             _context.SaveChanges();

            return Ok("Data Inserted");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTasks(TodoList list)
        {
            
            _context.todoLists.Update(list);
            await _context.SaveChangesAsync();
            return Ok(list);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTasks(int id)
        {
            var list = await _context.todoLists.FindAsync(id);

            if (list != null)
            {
                _context.Remove(list);
                await _context.SaveChangesAsync();
                return Ok("Data Deleted");
            }

            return NotFound();
        }
    }
}
