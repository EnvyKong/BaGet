using System.Collections.Generic;
using System.Text.Json.Serialization;
using BaGet.Protocol.Models;

namespace BaGet.Core
{
    /// <summary>
    /// BaGet's extensions to a registration index page.
    /// Extends <see cref="RegistrationIndexPage"/>.
    /// </summary>
    public class BaGetRegistrationIndexPage
    {
        [JsonPropertyName("@id")]
        public string RegistrationPageUrl { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("lower")]
        public string Lower { get; set; }

        [JsonPropertyName("upper")]
        public string Upper { get; set; }

        /// <summary>
        /// This was modified to use BaGet's extended registration index page item model.
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<BaGetRegistrationIndexPageItem> ItemsOrNull { get; set; }
    }
}
