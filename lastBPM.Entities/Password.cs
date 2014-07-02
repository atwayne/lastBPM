using System;

namespace lastBPM.Entities
{
    /// <summary>
    /// Password of User
    /// </summary>
    public class Password : Entry
    {
        public virtual User User { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public DateTime ExpireTime { get; set; }
    }
}
