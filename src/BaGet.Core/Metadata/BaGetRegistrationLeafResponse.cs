using System.Text.Json.Serialization;
using BaGet.Protocol.Models;

namespace BaGet.Core
{
    /// <summary>
    /// BaGet's extensions to a registration leaf response. These additions
    /// are not part of the official protocol.
    /// </summary>
    public class BaGetRegistrationLeafResponse : RegistrationLeafResponse
    {
        [JsonPropertyName("downloads")]
        public long Downloads { get; set; }
    }
}
