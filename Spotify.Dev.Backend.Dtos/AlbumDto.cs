//-----------------------------------------------------------------------
// <copyright file="Album.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Juan Posada</author>
// <date>3/18/2024 7:29:29 PM</date>
// <summary>Código fuente clase Album.</summary>
//-----------------------------------------------------------------------


namespace Spotify.Dev.Backend.Dtos
{

    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// AlbumDto object ddefinition class.
    /// </summary>
    public class AlbumDto
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumDto"/> class.
        /// </summary>
        public AlbumDto()
        {
        }

        #endregion

        #region Properties
        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("items")]
        public AlbumElement[] Items { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("images")]
        public IList<ImageDto> Images { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        public partial class AlbumElement
        {

            [JsonProperty("artists")]
            public IList<ArtistDto> Artists { get; set; }

            [JsonProperty("available_markets")]
            public string[] AvailableMarkets { get; set; }

            [JsonProperty("href")]
            public Uri Href { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("images")]
            public IList<ImageDto> Images { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("release_date")]
            public string ReleaseDate { get; set; }

            [JsonProperty("total_tracks")]
            public long TotalTracks { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("uri")]
            public string Uri { get; set; }
        }
        #endregion

        #region Methods And Functions

        #endregion
    }
}