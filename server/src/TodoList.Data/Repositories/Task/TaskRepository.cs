namespace TodoList.Data.Repositories.Task
{
    using TodoList.Data.Repositories.Interfaces;
    using TodoList.Data.Repositories.Base;
    using TodoList.Data.Entities.Task;
    using TodoList.Data.Contexts.ApplicationDb;

    public class TaskRepository : RepositoryBase<TaskEntity>, ITaskRepository
    {
        public TaskRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
