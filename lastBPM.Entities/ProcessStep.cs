
namespace lastBPM.Entities
{
    public class ProcessStep : SoftDelete
    {
        public virtual ProcessGroup Group { get; set; }
        public int Index { get; set; }
    }
}
