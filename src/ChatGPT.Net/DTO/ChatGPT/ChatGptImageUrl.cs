using Newtonsoft.Json;

namespace ChatGPT.Net.DTO.ChatGPT
{
    public class ChatGptImageUrl
    {
        [JsonProperty("url")]
        public string Url { get; set; } //Can be base64 encoded: "data:image/jpeg;base64,{base64_image}"
    }
}
