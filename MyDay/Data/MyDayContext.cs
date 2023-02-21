using BlazorDB;
using Microsoft.EntityFrameworkCore;
using MyDay.Pages.TodoList.Model;

namespace MyDay.Data
{
    public class MyDayContext : BlazorDBContext
    {
        public DbSet<TodoListItem> TodoListItems { get; set; }
    }
}
