namespace TodoList.Services.Task
{
    using System.Threading.Tasks;

    using AutoMapper;

    using TodoList.Services.Interfaces;
    using TodoList.Services.Models.Task;
    using TodoList.Data.Repositories.Interfaces;
    using TodoList.Data.Entities.Task;

    public class TaskService : ITaskService
    {
        private readonly IMapper _mapper;

        private readonly ITaskRepository _taskRepository;

        public TaskService(IMapper mapper, ITaskRepository taskRepository)
        {
            _mapper = mapper;
            _taskRepository = taskRepository;
        }

        public async Task<List<TaskModel>> GetAllTasksAsync()
        {
            try
            {
                var result = await _taskRepository.GetAllAsync();

                var tasks = _mapper.Map<List<TaskModel>>(result);

                return tasks;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<TaskModel>>(ex);
            }
        }

        public async Task<bool> AddTaskAsync(TaskModel taskModel)
        {
            try
            {
                var task = _mapper.Map<TaskEntity>(taskModel);

                var result = await _taskRepository.AddAsync(task);

                return result;
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex);
            }
        }

        public async Task<bool> UpdateTaskAsync(TaskModel taskModel)
        {
            try
            {
                var task = _mapper.Map<TaskEntity>(taskModel);

                var result = await _taskRepository.UpdateAsync(task);

                return result;
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex);
            }
        }

        public async Task<bool> RemoveTaskAsync(TaskModel taskModel)
        {
            try
            {
                var task = _mapper.Map<TaskEntity>(taskModel);

                var result = await _taskRepository.RemoveAsync(task);

                return result;
            }
            catch (Exception ex)
            {
                return await Task.FromException<bool>(ex);
            }
        }
    }
}
