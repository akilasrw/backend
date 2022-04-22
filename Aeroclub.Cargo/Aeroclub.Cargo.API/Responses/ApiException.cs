namespace Aeroclub.Cargo.API.Responses
{
    public class ApiException
    {
        public ApiException(int statusCode, string message = null, string details = null) //: base(statusCode, message)
        {
            Details = details;
        }

        public string Details { get; set; }
    }
}
