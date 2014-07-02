using System;

namespace lastBPM.Entities
{
    public class Approval : SoftDelete
    {
        public int Id { get; set; }
        public virtual Task Task { get; set; }
        public string Comment { get; set; }

        public ApprovalActions Action { get; set; }
        public DateTime ActionTime { get; set; }
    }

    public enum ApprovalActions
    {
        Approve,
        Reject
    }
}
