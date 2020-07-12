using System.Text.Json.Serialization;
using BaGet.Protocol.Models;

namespace BaGet.Core
{
    /// <summary>
    /// BaGet's extensions to a registration index page.
    /// Extends <see cref="RegistrationIndexPageItem"/>.
    /// </summary>
    public class BaGetRegistrationIndexPageItem
    {
        [JsonPropertyName("@id")]
        public string RegistrationLeafUrl { get; set; }

        [JsonPropertyName("packageContent")]
        public string PackageContentUrl { get; set; }

        /// <summary>
        /// The catalog entry containing the package metadata.
        /// This was modified to use BaGet's extended package metadata model.
        /// </summary>
        [JsonPropertyName("catalogEntry")]
        public BaGetPackageMetadata PackageMetadata { get; set; }
    }
}
