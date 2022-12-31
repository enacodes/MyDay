using MyDay.Pages.Todo.Model;

namespace MyDay.Pages.Project.Model
{
    public class ProjectItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
