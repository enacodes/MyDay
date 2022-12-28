using MyDay.Pages.Todo.Model;

namespace MyDay.Pages.Todo
{
    public class TaskItem
    {
        public int BucketId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskItemStatus Status { get; set; }
    }
}
