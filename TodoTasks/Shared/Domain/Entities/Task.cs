using TodoTasks.Shared.Domain.Entities.Common;

namespace TodoTasks.Shared.Domain.Entities
{
    public class Task : EntityBase
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public TimeSpan Duration { get; set; }
        public Status Status { get; set; }
        public Periodicity Periodicity { get; set; }
        public DateTime? InitDate { get; set; }
        public DateTime? EndDate { get; set; }

        public bool IsCompleted 
        {
            get 
            { 
                if (Status == Status.Completed) return true; else return false; 
            } 
        }
    }
}