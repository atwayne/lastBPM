using System;

namespace lastBPM.Entities
{
    /// <summary>
    /// Impersonate record
    /// A use could impersonate as another user
    /// </summary>
    public class Impersonate : Entry
    {
        public int Id { get; set; }

        public virtual User User { get; set; }
        public virtual User ImpersonateAs { get; set; }
        public DateTime? EffectiveTime { get; set; }
        public DateTime? ExpirationTime { get; set; }
    }
}
