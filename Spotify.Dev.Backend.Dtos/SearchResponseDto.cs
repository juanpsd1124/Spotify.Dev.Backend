//----------------------------------------------------------------------
// <copyright file="SearchResponseDto.cs">
//     All rights reserved.
// </copyright>
// <author>jposada</author>
// <date>17/08/2024</date>
// <summary>SearchResponseDto Definition.</summary>
//-----------------------------------------------------------------------

namespace Spotify.Dev.Backend.Dtos
{
    public class SearchResponseDto
    {

        #region Attributes

        #endregion

        #region Constructors

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets artists
        /// </summary>
        /// <value>artists</value>
        public ArtistDto artists { get; set; }

        /// <summary>
        /// Gets or sets artists
        /// </summary>
        /// <value>artists</value>
        public AlbumDto albums { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 
        /// </summary>
        /// <value></value>
        public TrackDto tracks { get; set; }

        #endregion

        #region Methods And Functionss

        #endregion
    }

}

