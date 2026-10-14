using Postman.Models;
using System.Text.Json;

namespace Postman.Services
{
    public class HistoryService
    {
        private readonly string _filePath = "request-history.json";

        public List<RequestHistoryItem> LoadHistory()
        {
            if (!File.Exists(_filePath))
            {
                return new List<RequestHistoryItem>();
            }

            string json = File.ReadAllText(_filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<RequestHistoryItem>();
            }

            List<RequestHistoryItem>? historyItems =
                JsonSerializer.Deserialize<List<RequestHistoryItem>>(json);

            if (historyItems == null)
            {
                return new List<RequestHistoryItem>();
            }

            return historyItems
                .OrderByDescending(x => x.SentAt)
                .ToList();
        }

        public void SaveRequest(RequestHistoryItem item)
        {
            List<RequestHistoryItem> historyItems = LoadHistory();

            historyItems.Add(item);

            historyItems = historyItems
                .OrderByDescending(x => x.SentAt)
                .ToList();

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(historyItems, options);

            File.WriteAllText(_filePath, json);
        }

        public void ClearHistory()
        {
            if (File.Exists(_filePath))
            {
                File.Delete(_filePath);
            }
        }
    }
}
