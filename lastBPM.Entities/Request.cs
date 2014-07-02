
namespace lastBPM.Entities
{
    /// <summary>
    /// Request
    /// Anything that could be approved/denied is a request
    /// </summary>
    public class Request : SoftDelete
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public virtual RequestType Type { get; set; }
        public RequestStatus Status { get; set; }
    }


    public enum RequestStatus
    {
        Draft,
        Closed,
        Approved
    }
}
