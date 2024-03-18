//----------------------------------------------------------------------
// <copyright file="LoginTokenResponseDto.cs">
//     All rights reserved.
// </copyright>
// <author>jposada</author>
// <date>17/08/2024</date>
// <summary>LoginTokenResponseDto Definition.</summary>
//-----------------------------------------------------------------------

namespace Spotify.Dev.Backend.Dtos
{
    public class LoginTokenResponseDto
    {

        #region Attributes

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginTokenResponseDto"/> class.
        /// </summary>
        public LoginTokenResponseDto()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets AccessToken
        /// </summary>
        /// <value>AccessToken.</value>
        public string Access_Token { get; set; }

        /// <summary>
        /// Gets or sets Token_type
        /// </summary>
        /// <value>Token_type</value>
        public string Token_type { get; set; }

        /// <summary>
        /// Gets or sets Expires_in
        /// </summary>
        /// <value>Expires_in</value>
        public int Expires_in { get; set; }

        /// <summary>
        /// Gets or sets RefreshToken
        /// </summary>
        /// <value>RefreshToken.</value>
        public string Refresh_Token { get; set; }

        /// <summary>
        /// Gets or sets RedirectUrl
        /// </summary>
        /// <value>RedirectUrl.</value>
        public string RedirectUrl { get; set; }



        #endregion

        #region Methods And Functionss

        #endregion
    }
}

