namespace TodoList.Services.Interfaces
{
    using TodoList.Services.Models.Task;

    public interface ITaskService
    {
        Task<List<TaskModel>> GetAllTasksAsync();

        Task<TaskModel> AddTaskAsync(TaskModel taskModel);

        Task<TaskModel> UpdateTaskAsync(TaskModel taskModel);

        Task<TaskModel> RemoveTaskAsync(TaskModel taskModel);
    }
}
