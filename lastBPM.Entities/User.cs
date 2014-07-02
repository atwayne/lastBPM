using System;
using System.Collections.Generic;

namespace lastBPM.Entities
{
    /// <summary>
    /// Users
    /// User could join many roles
    /// </summary>
    public class User : SoftDelete
    {
        public string Alias { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }

        public virtual List<Role> Roles { get; set; }
    }
}
