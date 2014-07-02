using System;

namespace lastBPM.Entities
{
    public class Task : SoftDelete
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompltedAt { get; set; }
        public string Comment { get; set; }

        public TaskStatus Status { get; set; }

        public virtual Request Request { get; set; }
        public virtual ProcessStep ProcessStep { get; set; }

        public virtual User AssignedTo { get; set; }
        public virtual User AssignedBy { get; set; }
    }

    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed
    }
}
