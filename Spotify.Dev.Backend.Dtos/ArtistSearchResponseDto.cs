//-----------------------------------------------------------------------
// <copyright file="ArtistSearchResponseDto.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Juan Posada</author>
// <date>3/18/2024 10:58:37 PM</date>
// <summary>Código fuente clase ArtistSearchResponseDto.</summary>
//-----------------------------------------------------------------------
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Spotify.Dev.Backend.Dtos
{
    /// <summary>
    /// ArtistSearchResponseDto class.
    /// </summary>
    public class ArtistSearchResponseDto
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistSearchResponseDto"/> class.
        /// </summary>
        public ArtistSearchResponseDto()
        {
        }

        #endregion

        #region Properties
        [JsonProperty("external_urls")]
        public ExternalUrls ExternalUrls { get; set; }

        [JsonProperty("followers")]
        public Followers Followers { get; set; }

        [JsonProperty("genres")]
        public string[] Genres { get; set; }

        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public ImageDto[] Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("popularity")]
        public long Popularity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public partial class Followers
    {
        [JsonProperty("href")]
        public object Href { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

    public partial class ExternalUrls
    {
        [JsonPropertyName("spotify")]
        public string Spotify { get; set; }
    }
    #endregion

    #region Methods And Functions

    #endregion
}