//-----------------------------------------------------------------------
// <copyright file="AlbumSearchResponseDto.cs" company="None">
//     All rights reserved.
// </copyright>
// <author>Juan Posada</author>
// <date>3/18/2024 11:29:55 PM</date>
// <summary>Código fuente clase AlbumSearchResponseDto.</summary>
//-----------------------------------------------------------------------


namespace Spotify.Dev.Backend.Dtos
{

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using static System.Net.Mime.MediaTypeNames;
    using System.Text.Json.Serialization;

    /// <summary>
    /// AlbumSearchResponseDto class.
    /// </summary>
    public class AlbumSearchResponseDto
    {
        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumSearchResponseDto"/> class.
        /// </summary>
        public AlbumSearchResponseDto()
        {
        }

        #endregion

        #region Properties
        [JsonPropertyName("album_type")]
        public string AlbumType { get; set; }

        [JsonPropertyName("artists")]
        public Artist[] Artists { get; set; }

        [JsonPropertyName("available_markets")]
        public string[] AvailableMarkets { get; set; }

        [JsonPropertyName("copyrights")]
        public Copyright[] Copyrights { get; set; }

        [JsonPropertyName("external_ids")]
        public ExternalIds ExternalIds { get; set; }

        [JsonPropertyName("external_urls")]
        public ExternalUrls ExternalUrls { get; set; }

        [JsonPropertyName("genres")]
        public object[] Genres { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("images")]
        public ImageDto[] Images { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("popularity")]
        public long Popularity { get; set; }

        [JsonPropertyName("release_date")]
        public DateTimeOffset ReleaseDate { get; set; }

        [JsonPropertyName("release_date_precision")]
        public string ReleaseDatePrecision { get; set; }

        [JsonPropertyName("total_tracks")]
        public long TotalTracks { get; set; }

        [JsonPropertyName("tracks")]
        public Tracks Tracks { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }
        #endregion

        #region Methods And Functions

        #endregion
    }

    public partial class Artist
    {
        [JsonPropertyName("external_urls")]
        public ExternalUrls ExternalUrls { get; set; }

        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }

    public partial class Copyright
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public partial class ExternalIds
    {
        [JsonPropertyName("upc")]
        public string Upc { get; set; }
    }

    public partial class Image
    {
        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("width")]
        public long Width { get; set; }
    }

    public partial class Tracks
    {
        [JsonPropertyName("href")]
        public Uri Href { get; set; }

        [JsonPropertyName("items")]
        public Item[] Items { get; set; }

        [JsonPropertyName("limit")]
        public long Limit { get; set; }

        [JsonPropertyName("next")]
        public object Next { get; set; }

        [JsonPropertyName("offset")]
        public long Offset { get; set; }

        [JsonPropertyName("previous")]
        public object Previous { get; set; }

        [JsonPropertyName("total")]
        public long Total { get; set; }
    }

    public partial class Item
    {
        [JsonPropertyName("artists")]
        public Artist[] Artists { get; set; }

        [JsonPropertyName("available_markets")]
        public string[] AvailableMarkets { get; set; }

        [JsonPropertyName("disc_number")]
        public long DiscNumber { get; set; }

        [JsonPropertyName("duration_ms")]
        public long DurationMs { get; set; }

        [JsonPropertyName("explicit")]
        public bool Explicit { get; set; }

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

        [JsonPropertyName("preview_url")]
        public Uri PreviewUrl { get; set; }

        [JsonPropertyName("track_number")]
        public long TrackNumber { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}