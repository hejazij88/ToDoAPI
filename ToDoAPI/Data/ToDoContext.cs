using Microsoft.EntityFrameworkCore;
using ToDoAPI.Model;

namespace ToDoAPI.Data;

public class ToDoContext:DbContext
{
    public ToDoContext(DbContextOptions<ToDoContext> options):base(options)
    {
        
    }
    public DbSet<ToDoItem>ToDoItems  { get; set; }
}