using System.Collections.Generic;

namespace lastBPM.Entities
{
    /// <summary>
    /// Roles
    /// Role could have many permissions
    /// </summary>
    public class Role : SoftDelete
    {
        public string Alias { get; set; }
        public string DisplayName { get; set; }

        public virtual List<Permission> Permissions { get; set; }
    }
}
