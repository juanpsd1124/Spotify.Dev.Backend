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
            LoginTokenResponseDto result = this.SpotifyBL.RequestAccessToken(code);
            return Redirect($"http://localhost:4200/home/search?resToken={result.Access_Token}");
        }

        /// <summary>
        /// "Method for request spotify auth token.
        /// </summary>
        /// <param name="term">TSearch term entered by user.</param>
        /// <param name="token">Spotify user auth token.</param>
        /// <returns>SearchResponseDto</returns>
        [HttpGet("searchTerm")]
        [SwaggerResponse(statusCode: 200, type: typeof(SearchResponseDto), description: "Method for search term requested by user")]
        public IActionResult SearchTerm([FromQuery] string term, [FromQuery] string token) 
        {
            SearchResponseDto result = this.SpotifyBL.SearchTerm(term, token);
            return (Ok(result));


        }


        #endregion






    }
}
