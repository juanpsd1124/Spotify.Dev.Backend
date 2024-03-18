using Spotify.Dev.Backend.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Dev.Backend.Utils
{
    public interface IHttpClientManager<U>
    {

        Task<U> Get(Uri url, MediaTypeFormatter mediaTypeFormatter, IList<HttpParamsDto> queryParams, IList<HttpParamsDto> headers);

        Task<U> Post(Uri url, MediaTypeFormatter mediaTypeFormatter, AuthenticationHeaderValue authorize, IList<HttpParamsDto> queryParams, IList<HttpParamsDto> headers);


    }
}
