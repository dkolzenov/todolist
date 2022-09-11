namespace TodoList.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using TodoList.Services.Interfaces;
    using TodoList.Services.Models.Task;

    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TaskModel>>> GetAllTasksAsync()
        {
            var tasks = await _taskService.GetAllTasksAsync();

            return tasks;
        }

        [HttpPost]
        public async Task<ActionResult<TaskModel>> AddTaskAsync(TaskModel task)
        {
            var addedTask = await _taskService.AddTaskAsync(task);

            return addedTask;
        }

        [HttpPut]
        public async Task<ActionResult<TaskModel>> UpdateTaskAsync(TaskModel task)
        {
            var updatedTask = await _taskService.UpdateTaskAsync(task);

            return updatedTask;
        }

        [HttpDelete]
        public async Task<ActionResult<TaskModel>> RemoveTaskAsync(TaskModel task)
        {
            var removedTask = await _taskService.RemoveTaskAsync(task);

            return removedTask;
        }
    }
}
