using System.Text.Json.Serialization;

namespace APIExample.Core
{
    public class CustomResponse<T>
    {
        public T Data { get; set; }
        public List<string> Error { get; set; }
        [JsonIgnore]
        public int Status { get; set; }
    }
}