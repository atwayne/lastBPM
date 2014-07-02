using System.Collections.Generic;

namespace lastBPM.Entities
{
    /// <summary>
    /// ProcessGroup is a group of ProcessSteps
    /// </summary>
    public class ProcessGroup : SoftDelete
    {
        public string Alias { get; set; }
        public string DisplayText { get; set; }

        public int Index { get; set; }

        public virtual List<ProcessStep> Steps { get; set; }
    }
}
