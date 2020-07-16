namespace Godel.HelloWorld.Models
{
    public class ErrorViewModel
    {
        public string Setting { get; set; }
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}