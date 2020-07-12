using System.Collections.Generic;
using System.Text.Json.Serialization;
using BaGet.Protocol.Models;

namespace BaGet.Core
{
    /// <summary>
    /// BaGet's extensions to a registration index response.
    /// Extends <see cref="RegistrationIndexResponse"/>.
    /// </summary>
    public class BaGetRegistrationIndexResponse
    {
        [JsonPropertyName("@id")]
        public string RegistrationIndexUrl { get; set; }

        [JsonPropertyName("@type")]
        public IReadOnlyList<string> Type { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// The pages that contain all of the versions of the package, ordered
        /// by the package's version. This was modified to use BaGet's extended
        /// registration index page model.
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<BaGetRegistrationIndexPage> Pages { get; set; }

        /// <summary>
        /// The package's total downloads across all versions.
        /// This is not part of the official NuGet protocol.
        /// </summary>
        [JsonPropertyName("totalDownloads")]
        public long TotalDownloads { get; set; }
    }
}
