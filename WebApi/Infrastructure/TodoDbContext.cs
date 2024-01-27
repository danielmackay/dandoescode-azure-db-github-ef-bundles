using Microsoft.EntityFrameworkCore;
using WebApi.Domain;

namespace WebApi.Infrastructure;

public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
}
