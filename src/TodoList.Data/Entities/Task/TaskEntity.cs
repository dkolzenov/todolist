namespace TodoList.Data.Entities.Task
{
    public class TaskEntity
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
