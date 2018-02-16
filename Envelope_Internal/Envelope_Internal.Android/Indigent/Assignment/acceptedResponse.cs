namespace Envelope_Internal.Indigent.Assignment
{
    public class StatusResponse
    {
        public string StatusDescription { get; set; }
        public string StatusCode { get; set; }
    }

    public class acceptedResponse
    {
        public StatusResponse StatusResponse { get; set; }
    }
}