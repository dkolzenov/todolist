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
        public async Task<ActionResult<bool>> AddTaskAsync(TaskModel taskModel)
        {
            var result = await _taskService.AddTaskAsync(taskModel);

            return result;
        }

        [HttpPut]
        public async Task<ActionResult<bool>> UpdateTaskAsync(TaskModel taskModel)
        {
            var result = await _taskService.UpdateTaskAsync(taskModel);

            return result;
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> RemoveTaskAsync(TaskModel taskModel)
        {
            var result = await _taskService.RemoveTaskAsync(taskModel);

            return result;
        }
    }
}
