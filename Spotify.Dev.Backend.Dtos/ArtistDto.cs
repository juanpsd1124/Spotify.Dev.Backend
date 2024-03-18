//----------------------------------------------------------------------
// <copyright file="ArtistDto.cs">
//     All rights reserved.
// </copyright>
// <author>jposada</author>
// <date>17/08/2024</date>
// <summary>ArtistDto Definition.</summary>
//-----------------------------------------------------------------------

namespace Spotify.Dev.Backend.Dtos
{

    using Newtonsoft.Json;
    using System;
    public class ArtistDto
    {
        #region Attributes

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public partial class Artists : ArtistDto
        {
            [JsonProperty("href")]
            public Uri Href { get; set; }

            [JsonProperty("items")]
            public ArtistsItem[] Items { get; set; }

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
        }

        public partial class ArtistsItem
        {

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



            [JsonProperty("uri")]
            public string Uri { get; set; }
        }


        #endregion

        #region Methods And Functionss

        #endregion

    }
}
