
using System.Collections.Generic;
namespace lastBPM.Entities
{
    /// <summary>
    /// Request type of Request
    /// </summary>
    public class RequestType : SoftDelete
    {
        public string Alias { get; set; }
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public virtual List<ProcessGroup> ProcessGroups { get; set; }
    }
}
