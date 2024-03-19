
//----------------------------------------------------------------------
// <copyright file="ISpotifyBL.cs">
//     All rights reserved.
// </copyright>
// <author>jposada</author>
// <date>17/08/2024</date>
// <summary>ISpotifyBL interface.</summary>
//-----------------------------------------------------------------------

namespace Spotify.Dev.Backend.BL
{
    using Spotify.Dev.Backend.Dtos;
    public interface ISpotifyBL
    {
        /// <summary>
        /// Method to request access token to spotify API
        /// </summary>
        /// <param name="code">Code provider from frontend OAuth authorization code.</param>
        /// <returns>LoginTokenResponseDto</returns>
        LoginTokenResponseDto RequestAccessToken(string code);
        
        /// <summary>
        /// Method for search terms on spotify
        /// </summary>
        /// <param name="term">Term entered by user.</param>
        /// <param name="token">Access web token.</param>
        /// <returns>SearchResponseDto</returns>
        SearchResponseDto SearchTerm(string term, string token);

        /// <summary>
        /// Method for search a track on spotify using track id
        /// </summary>
        /// <param name="id">Artist unique id.</param>
        /// <param name="token">Access web token.</param>
        /// <returns>SearchResponseDto</returns>
        ArtistSearchResponseDto SearchArtist(string id, string token);

        /// <summary>
        /// Method for search a track on spotify using track id
        /// </summary>
        /// <param name="id">Album unique id.</param>
        /// <param name="token">Access web token.</param>
        /// <returns>SearchResponseDto</returns>
        AlbumSearchResponseDto SearchAlbum(string id, string token);

        /// <summary>
        /// Method for search a track on spotify using track id
        /// </summary>
        /// <param name="id">Track unique id.</param>
        /// <param name="token">Access web token.</param>
        /// <returns>SearchResponseDto</returns>
        TrackSearchResponseDto SearchTrack(string id, string token);

    }
}
