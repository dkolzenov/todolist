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
                List<TaskEntity> result = await _taskRepository.GetAllAsync();

                var tasks = _mapper.Map<List<TaskModel>>(result);

                return tasks;
            }
            catch (Exception ex)
            {
                return await Task.FromException<List<TaskModel>>(ex);
            }
        }

        public async Task<TaskModel> AddTaskAsync(TaskModel taskModel)
        {
            try
            {
                var taskEntity = _mapper.Map<TaskEntity>(taskModel);

                TaskEntity result = await _taskRepository.AddAsync(taskEntity);

                var addedTask = _mapper.Map<TaskModel>(result);

                return addedTask;
            }
            catch (Exception ex)
            {
                return await Task.FromException<TaskModel>(ex);
            }
        }

        public async Task<TaskModel> UpdateTaskAsync(TaskModel taskModel)
        {
            try
            {
                var taskEntity = _mapper.Map<TaskEntity>(taskModel);

                TaskEntity result = await _taskRepository
                    .UpdateAsync(taskEntity);

                var updatedTask = _mapper.Map<TaskModel>(result);

                return updatedTask;
            }
            catch (Exception ex)
            {
                return await Task.FromException<TaskModel>(ex);
            }
        }

        public async Task<TaskModel> RemoveTaskAsync(TaskModel taskModel)
        {
            try
            {
                var taskEntity = _mapper.Map<TaskEntity>(taskModel);

                TaskEntity result = await _taskRepository
                    .RemoveAsync(taskEntity);

                var removedTask = _mapper.Map<TaskModel>(result);

                return removedTask;
            }
            catch (Exception ex)
            {
                return await Task.FromException<TaskModel>(ex);
            }
        }
    }
}
