namespace lastBPM.Entities
{
    /// <summary>
    /// Permission
    /// A permission is something pre defined in code. Used for access-control
    /// </summary>
    public class Permission : SoftDelete
    {
        public string Alias { get; set; }
        public string Parameter { get; set; }
        public string Description { get; set; }
    }
}
