using System;
using Unity.Plastic.Newtonsoft.Json;

namespace MCPForUnity.Editor.Models
{
    [Serializable]
    public class McpConfigServers
    {
        [JsonProperty("unityMCP")]
        public McpConfigServer unityMCP;
    }
}
