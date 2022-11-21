namespace TodoListApi.Models
{
    public class AddTaskRequest
    {
        public string? Task { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
    }
}
