namespace Postman.Models
{
    public class ApiResponseModel
    {
        public int StatusCode { get; set; }
        public string ReasonPhrase { get; set; } = "";
        public string Content { get; set; } = "";
        public long Length { get; set; }
        public long ElapsedMilliseconds { get; set; }
    }
}
