namespace Postman.Models
{
    public class RequestHistoryItem
    {
        public DateTime SentAt { get; set; }

        public string Method { get; set; } = "";
        public string Url { get; set; } = "";

        public List<HistoryParameterModel> QueryParams { get; set; } = new List<HistoryParameterModel>();
        public List<HistoryParameterModel> PathParams { get; set; } = new List<HistoryParameterModel>();
        public List<HistoryParameterModel> Headers { get; set; } = new List<HistoryParameterModel>();

        public string BodyType { get; set; } = "";
        public string Body { get; set; } = "";
        public int StatusCode { get; set; }
        public string ReasonPhrase { get; set; } = "";
        public long ResponseLength { get; set; }
        public long ElapsedMilliseconds { get; set; }
        public string ResponseContent { get; set; } = "";

        public override string ToString()
        {
            return Method + " " + Url;
        }
    }
}
