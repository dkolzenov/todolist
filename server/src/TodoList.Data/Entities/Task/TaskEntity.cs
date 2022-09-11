namespace TodoList.Data.Entities.Task
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Task")]
    public class TaskEntity
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
