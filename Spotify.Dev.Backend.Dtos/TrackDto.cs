//-----------------------------------------------------------------------
// <copyright file="TrackDto.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Juan Posada</author>
// <date>3/18/2024 7:41:17 PM</date>
// <summary>Código fuente clase TrackDto.</summary>
//-----------------------------------------------------------------------

namespace Spotify.Dev.Backend.Dtos
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// TrackDto object definition class.
    /// </summary>
    public class TrackDto
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackDto"/> class.
        /// </summary>
        public TrackDto()
        {
        }

        #endregion

        #region Properties


        [JsonProperty("href")]
        public Uri Href { get; set; }

        [JsonProperty("items")]
        public TracksItem[] Items { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("next")]
        public Uri Next { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
        

        public partial class TracksItem
        {
            [JsonProperty("album")]
            public AlbumDto Album { get; set; }

            [JsonProperty("artists")]
            public ArtistDto[] Artists { get; set; }

            [JsonProperty("available_markets")]
            public string[] AvailableMarkets { get; set; }

            [JsonProperty("disc_number")]
            public long DiscNumber { get; set; }

            [JsonProperty("duration_ms")]
            public long DurationMs { get; set; }

            [JsonProperty("explicit")]
            public bool Explicit { get; set; }

            [JsonProperty("href")]
            public Uri Href { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("is_local")]
            public bool IsLocal { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("popularity")]
            public long Popularity { get; set; }

            [JsonProperty("preview_url")]
            public Uri PreviewUrl { get; set; }

            [JsonProperty("track_number")]
            public long TrackNumber { get; set; }

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