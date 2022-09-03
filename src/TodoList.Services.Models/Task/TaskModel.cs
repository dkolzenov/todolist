namespace TodoList.Services.Models.Task
{
    public class TaskModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
