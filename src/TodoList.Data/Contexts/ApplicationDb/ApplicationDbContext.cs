namespace TodoList.Data.Contexts.ApplicationDb
{
    using Microsoft.EntityFrameworkCore;

    using TodoList.Data.Entities.Task;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<TaskEntity> Tasks { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
