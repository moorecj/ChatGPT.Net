using Newtonsoft.Json;

namespace ChatGPT.Net.DTO.ChatGPT
{
    public class ChatGptContent

    {
        [JsonProperty("type")] // text or image_url
        public string Type { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public ChatGptImageUrl ImageUrl { get; set; }
    }
}
