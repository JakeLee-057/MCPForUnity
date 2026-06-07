using System;
using Unity.Plastic.Newtonsoft.Json;

namespace MCPForUnity.Editor.Models
{
    [Serializable]
    public class McpConfig
    {
        [JsonProperty("mcpServers")]
        public McpConfigServers mcpServers;
    }
}
