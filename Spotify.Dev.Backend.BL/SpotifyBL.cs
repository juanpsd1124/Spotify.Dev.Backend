//----------------------------------------------------------------------
// <copyright file="SpotifyBl.cs">
//     All rights reserved.
// </copyright>
// <author>jposada</author>
// <date>17/08/2024</date>
// <summary>SpotifyBL.</summary>
//-----------------------------------------------------------------------

namespace Spotify.Dev.Backend.BL
{
    using Microsoft.Extensions.Configuration;
    using Spotify.Dev.Backend.Dtos;
    using Spotify.Dev.Backend.Utils;
    using System;
    using System.Collections.Generic;
    using System.Net.Http.Formatting;
    using System.Text;

    public class SpotifyBL : ISpotifyBL
    {

        #region Attributes

        #endregion

        #region Constructors
        public SpotifyBL(IConfiguration configuration) { 
            this.Configuration = configuration;
            this.ClientId = this.Configuration.GetSection("Spotify_Access_Ids").GetSection("ClientId").Value;
            this.SecretId = this.Configuration.GetSection("Spotify_Access_Ids").GetSection("SecretId").Value;
            
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a value indicating Configuration Object.
        /// </summary>
        /// <value>Configuration Object.</value>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating ClientId.
        /// </summary>
        /// <value>Spotify client id.</value>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether SecretId.
        /// </summary>
        /// <value>Spotify secret id.</value>
        public string SecretId { get; set; }

        #endregion

        #region Methods And Functions

        /// <summary>
        /// Method to request access token to spotify API
        /// </summary>
        /// <param name="code">Code provider from frontend OAuth authorization code.</param>
        /// <returns>LoginTokenResponseDto</returns>
        public LoginTokenResponseDto RequestAccessToken(string code)
        {
            try
            {
                string encodedAuthorization = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{this.ClientId}:{this.SecretId}"));

                IList<HttpParamsDto> paramsTest = new List<HttpParamsDto>() {
                new HttpParamsDto() { Key = "grant_type", Value = "authorization_code" },
                new HttpParamsDto() { Key = "code", Value = code },
                new HttpParamsDto() { Key = "redirect_uri", Value = "http://localhost:5066/api/Spotify/login" }
                };

                IList<HttpParamsDto> headersTest = new List<HttpParamsDto>() {
                new HttpParamsDto() { Key = "Authorization", Value = $"Basic {encodedAuthorization}" }
                };

                Uri url = new Uri("https://accounts.spotify.com/api/token?");

                IHttpClientManager<LoginTokenResponseDto> httpManagerInstance = new HttpClientManager<object, LoginTokenResponseDto>();

                LoginTokenResponseDto result = httpManagerInstance.Post(url, new JsonMediaTypeFormatter(), null, paramsTest, headersTest).GetAwaiter().GetResult();
                result.RedirectUrl = "http://localhost:4200/home/search";

                return result;

            }

            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Method for search terms on spotify
        /// </summary>
        /// <param name="term">Term entered by user.</param>
        /// <param name="token">Access web token.</param>
        /// <returns>SearchResponseDto</returns>
        public SearchResponseDto SearchTerm(string term, string token)
        {
            try
            {
                IList<HttpParamsDto> paramsTest = new List<HttpParamsDto>() {
                new HttpParamsDto() { Key = "q", Value = term, },
                new HttpParamsDto() { Key = "type", Value = "album,track,artist" }
                };

                IList<HttpParamsDto> headersTest = new List<HttpParamsDto>() {
                new HttpParamsDto() { Key = "Authorization", Value = $"Bearer {token}" }
                };

                Uri url = new Uri("https://api.spotify.com/v1/search?");

                IHttpClientManager<SearchResponseDto> httpManagerInstance = new HttpClientManager<object, SearchResponseDto>();

                SearchResponseDto result = httpManagerInstance.Get(url, new JsonMediaTypeFormatter(), paramsTest, headersTest).GetAwaiter().GetResult();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        /// <summary>
        /// Method for search a artist on spotify using artist id
        /// </summary>
        /// <param name="id">Artist unique id.</param>
        /// <param name="token">Access web token.</param>
        /// <returns>SearchResponseDto</returns>
        public ArtistSearchResponseDto SearchArtist(string id, string token)
        {
            try
            {
                IList<HttpParamsDto> headersTest = new List<HttpParamsDto>() {
                new HttpParamsDto() { Key = "Authorization", Value = $"Bearer {token}" }
                };

                Uri url = new Uri($"https://api.spotify.com/v1/artists/{id}");

                IHttpClientManager<ArtistSearchResponseDto> httpManagerInstance = new HttpClientManager<object, ArtistSearchResponseDto>();

                ArtistSearchResponseDto result = httpManagerInstance.Get(url, new JsonMediaTypeFormatter(), null, headersTest).GetAwaiter().GetResult();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        /// <summary>
        /// Method for search a album on spotify using album id
        /// </summary>
        /// <param name="id">Album unique id.</param>
        /// <param name="token">Access web token.</param>
        /// <returns>SearchResponseDto</returns>
        public AlbumSearchResponseDto SearchAlbum(string id, string token)
        {
            try
            {
                IList<HttpParamsDto> headersTest = new List<HttpParamsDto>() {
                new HttpParamsDto() { Key = "Authorization", Value = $"Bearer {token}" }
                };

                Uri url = new Uri($"https://api.spotify.com/v1/albums/{id}");

                IHttpClientManager<AlbumSearchResponseDto> httpManagerInstance = new HttpClientManager<object, AlbumSearchResponseDto>();

                AlbumSearchResponseDto result = httpManagerInstance.Get(url, new JsonMediaTypeFormatter(), null, headersTest).GetAwaiter().GetResult();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        /// <summary>
        /// Method for search a track on spotify using track id
        /// </summary>
        /// <param name="id">Track unique id.</param>
        /// <param name="token">Access web token.</param>
        /// <returns>SearchResponseDto</returns>
        public TrackSearchResponseDto SearchTrack(string id, string token)
        {
            try
            {
                IList<HttpParamsDto> headersTest = new List<HttpParamsDto>() {
                new HttpParamsDto() { Key = "Authorization", Value = $"Bearer {token}" }
                };

                Uri url = new Uri($"https://api.spotify.com/v1/tracks/{id}");

                IHttpClientManager<TrackSearchResponseDto> httpManagerInstance = new HttpClientManager<object, TrackSearchResponseDto>();

                TrackSearchResponseDto result = httpManagerInstance.Get(url, new JsonMediaTypeFormatter(), null, headersTest).GetAwaiter().GetResult();

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        #endregion

    }
}
