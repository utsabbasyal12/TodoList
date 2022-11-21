using System.ComponentModel.DataAnnotations;

namespace TodoListApi.Models
{
    public class TodoList
    {
        [Key]
        public int Id { get; set; }
        public string? Task { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
    }
}
