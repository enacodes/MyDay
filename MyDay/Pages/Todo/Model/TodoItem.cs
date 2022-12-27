using MyDay.Pages.Todo.Model;

namespace MyDay.Pages.Todo
{
    public class TodoItem
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TodoStatus Status { get; set; }
    }
}
