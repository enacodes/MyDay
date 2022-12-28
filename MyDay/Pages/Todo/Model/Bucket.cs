namespace MyDay.Pages.Todo.Model
{
    public class Bucket
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<TaskItem> TaskItems { get; set; } = new List<TaskItem>();

        public bool AllowDelete { get; set; }
    }
}
