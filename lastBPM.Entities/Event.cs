using System;

namespace lastBPM.Entities
{
    /// <summary>
    /// LogEvent
    /// </summary>
    public class Event : SoftDelete
    {
        public DateTime Timestamp { get; set; }
        public EventType Type { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
    }

    public enum EventType
    {
        Active,
        Login,
        ChangePassword,
        JoinRole,
        LeftRole
    }
}
