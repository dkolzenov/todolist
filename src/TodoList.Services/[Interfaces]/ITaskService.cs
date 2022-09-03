namespace TodoList.Services.Interfaces
{
    using TodoList.Services.Models.Task;

    public interface ITaskService
    {
        Task<List<TaskModel>> GetAllTasksAsync();

        Task<bool> AddTaskAsync(TaskModel taskModel);

        Task<bool> UpdateTaskAsync(TaskModel taskModel);

        Task<bool> RemoveTaskAsync(TaskModel taskModel);
    }
}
