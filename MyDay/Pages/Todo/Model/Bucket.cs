namespace MyDay.Pages.Todo.Model
{
    public class Bucket
    {
        public string Name { get; set; } = string.Empty;
        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
    }
}
