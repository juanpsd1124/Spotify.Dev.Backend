//----------------------------------------------------------------------
// <copyright file=SpotifyController.cs">
//     All rights reserved.
// </copyright>
// <author>jposada</author>
// <date>17/08/2024</date>
// <summary>SpotifyController</summary>
//-----------------------------------------------------------------------

namespace WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Spotify.Dev.Backend.BL;
    using Spotify.Dev.Backend.Dtos;
    using Swashbuckle.AspNetCore.Annotations;


    /// <summary>
    /// SpotifyController Class - Spotify API request controller class
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class SpotifyController : ControllerBase
    {

        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor class method <see cref="SpotifyController"/>
        /// </summary>
        /// <param name="configuration">Configuration service dependency injection</param>
        /// <param name="spotifyBL">SpotifyBL dependency injection</param>
        public SpotifyController(IConfiguration configuration, ISpotifyBL spotifyBL) 
        {
            this.SpotifyBL = spotifyBL;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets Manejador de configuracion de la aplicacion.
        /// </summary>
        /// <value>Manejador de configuracion de la aplicacion.</value>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets or sets SpotifyBL to access Spotify business logic methods.
        /// </summary>
        /// <value>SpotifyBL.</value>
        private ISpotifyBL SpotifyBL;

        #endregion

        #region Methods and Functions
        /// <summary>
        /// "Method for request spotify auth token.
        /// </summary>
        /// <param name="code">Code emited by spotify OAuth authorization service.</param>
        /// <returns>LoginTokenResponseDto</returns>
        [HttpGet("login")]
        [SwaggerResponse(statusCode: 200, type: typeof(LoginTokenResponseDto), description: "Method for request spotify auth token")]
        public IActionResult GetSpotifyLogin([FromQuery]string code)
        {
            try
            {
                LoginTokenResponseDto result = this.SpotifyBL.RequestAccessToken(code);
                return Redirect($"http://localhost:4200/home/search?resToken={result.Access_Token}");
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// "Method for request spotify auth token.
        /// </summary>
        /// <param name="term">Search term entered by user.</param>
        /// <param name="token">Spotify user auth token.</param>
        /// <returns>SearchResponseDto</returns>
        [HttpGet("searchTerm")]
        [SwaggerResponse(statusCode: 200, type: typeof(SearchResponseDto), description: "Method for search term requested by user")]
        public IActionResult SearchTerm([FromQuery] string term, [FromQuery] string token) 
        {
            try
            {
                SearchResponseDto result = this.SpotifyBL.SearchTerm(term, token);
                return (Ok(result));
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Method for search an artist on spotify using artist id
        /// </summary>
        /// <param name="id">Artist unique id.</param>
        /// <param name="token">Spotify user auth token.</param>
        /// <returns>SearchResponseDto</returns>
        [HttpGet("searchArtist/{id}")]
        [SwaggerResponse(statusCode: 200, type: typeof(ArtistSearchResponseDto), description: "Method for search term requested by user")]
        public IActionResult SearchArtist(string id, [FromQuery] string token)
        {
            try
            {
                ArtistSearchResponseDto result = this.SpotifyBL.SearchArtist(id, token);
                return (Ok(result));
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Method for search an ambum on spotify using album id
        /// </summary>
        /// <param name="id">Album unique id.</param>
        /// <param name="token">Spotify user auth token.</param>
        /// <returns>AlbumSearchResponseDto</returns>
        [HttpGet("searchAlbum/{id}")]
        [SwaggerResponse(statusCode: 200, type: typeof(AlbumSearchResponseDto), description: "Method for search term requested by user")]
        public IActionResult SearchAlbum(string id, [FromQuery] string token)
        {
            try
            {
                AlbumSearchResponseDto result = this.SpotifyBL.SearchAlbum(id, token);
                return (Ok(result));
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Method for search an track on spotify using track id
        /// </summary>
        /// <param name="id">Track unique id.</param>
        /// <param name="token">Spotify user auth token.</param>
        /// <returns>TrackSearchResponseDto</returns>
        [HttpGet("searchTrack/{id}")]
        [SwaggerResponse(statusCode: 200, type: typeof(TrackSearchResponseDto), description: "Method for search term requested by user")]
        public IActionResult SearchTrack(string id, [FromQuery] string token)
        {
            try
            {
                TrackSearchResponseDto result = this.SpotifyBL.SearchTrack(id, token);
                return (Ok(result));
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        #endregion
    }
}
