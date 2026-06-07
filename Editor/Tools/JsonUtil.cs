using MCPForUnity.Editor.Helpers;
using Unity.Plastic.Newtonsoft.Json;
using Unity.Plastic.Newtonsoft.Json.Linq;

namespace MCPForUnity.Editor.Tools
{
    internal static class JsonUtil
    {
        /// <summary>
        /// If @params[paramName] is a JSON string, parse it to a JObject in-place.
        /// Logs a warning on parse failure and leaves the original value.
        /// </summary>
        internal static void CoerceJsonStringParameter(JObject @params, string paramName)
        {
            if (@params == null || string.IsNullOrEmpty(paramName)) return;
            var token = @params[paramName];
            if (token != null && token.Type == JTokenType.String)
            {
                try
                {
                    var parsed = JObject.Parse(token.ToString());
                    @params[paramName] = parsed;
                }
                catch (JsonReaderException e)
                {
                    McpLog.Warn($"[MCP] Could not parse '{paramName}' JSON string: {e.Message}");
                }
            }
        }
    }
}
