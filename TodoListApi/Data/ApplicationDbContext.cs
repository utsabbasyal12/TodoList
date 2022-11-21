using Microsoft.EntityFrameworkCore;
using TodoListApi.Models;

namespace TodoListApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<TodoList> todoLists { get; set; } 
    }
}
