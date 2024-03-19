//-----------------------------------------------------------------------
// <copyright file="TrackSearchResponseDto.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Juan Posada</author>
// <date>3/18/2024 11:33:43 PM</date>
// <summary>Código fuente clase TrackSearchResponseDto.</summary>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace Spotify.Dev.Backend.Dtos
{
    /// <summary>
    /// TrackSearchResponseDto class.
    /// </summary>
    public class TrackSearchResponseDto
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TrackSearchResponseDto"/> class.
        /// </summary>
        public TrackSearchResponseDto()
        {
        }

        #endregion

        #region Properties
        [JsonPropertyName("album")]
        public Album Album { get; set; }

        [JsonPropertyName("artists")]
        public Artist[] Artists { get; set; }

        [JsonPropertyName("available_markets")]
        public object[] AvailableMarkets { get; set; }

        [JsonPropertyName("disc_number")]
        public long DiscNumber { get; set; }

        [JsonPropertyName("duration_ms")]
        public long DurationMs { get; set; }

        [JsonPropertyName("explicit")]
        public bool Explicit { get; set; }

        [JsonPropertyName("external_ids")]
        public ExternalIds ExternalIds { get; set; }

        [JsonPropertyName("external_urls")]
        public ExternalUrls ExternalUrls { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("is_local")]
        public bool IsLocal { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("popularity")]
        public long Popularity { get; set; }

        [JsonPropertyName("preview_url")]
        public object PreviewUrl { get; set; }

        [JsonPropertyName("track_number")]
        public long TrackNumber { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        #endregion

        #region Methods And Functions

        #endregion
    }

    public partial class Album
    {
        [JsonPropertyName("album_type")]
        public string AlbumType { get; set; }

        [JsonPropertyName("artists")]
        public Artist[] Artists { get; set; }

        [JsonPropertyName("available_markets")]
        public object[] AvailableMarkets { get; set; }

        [JsonPropertyName("external_urls")]
        public ExternalUrls ExternalUrls { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("images")]
        public ImageDto[] Images { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        [JsonPropertyName("release_date_precision")]
        public string ReleaseDatePrecision { get; set; }

        [JsonPropertyName("total_tracks")]
        public long TotalTracks { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }

    public partial class Artist
    {

        [JsonPropertyName("type")]
        public string Type { get; set; }

    }


}