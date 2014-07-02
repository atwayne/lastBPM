using System;

namespace lastBPM.Entities
{
    /// <summary>
    /// Base class of any class whose instance could be soft deleted
    /// </summary>
    public abstract class SoftDelete : Entry
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}
