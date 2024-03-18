//----------------------------------------------------------------------
// <copyright file="ImageDto.cs">
//     All rights reserved.
// </copyright>
// <author>jposada</author>
// <date>17/08/2024</date>
// <summary>ImageDto Definition.</summary>
//-----------------------------------------------------------------------

namespace Spotify.Dev.Backend.Dtos
{
    using Newtonsoft.Json;
    public class ImageDto
    {

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }



    }
}
