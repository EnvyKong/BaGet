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
        /// <summary>
        /// The URL to the registration index.
        /// </summary>
        [JsonPropertyName("@id")]
        public string RegistrationIndexUrl { get; set; }

        /// <summary>
        /// The registration index's type.
        /// </summary>
        [JsonPropertyName("@type")]
        public IReadOnlyList<string> Type { get; set; }

        /// <summary>
        /// The number of registration pages. See <see cref="Pages"/>.
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// The pages that contain all of the versions of the package, ordered
        /// by the package's version.
        /// </summary>
        [JsonPropertyName("items")]
        public IReadOnlyList<RegistrationIndexPage> Pages { get; set; }

        /// <summary>
        /// How many times all versions of this package have been downloaded.
        /// This is not part of the official NuGet protocol.
        /// </summary>
        [JsonPropertyName("totalDownloads")]
        public long TotalDownloads { get; set; }
    }
}
