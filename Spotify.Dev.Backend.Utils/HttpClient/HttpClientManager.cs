

namespace Spotify.Dev.Backend.Utils
{
    using Newtonsoft.Json;
    using Spotify.Dev.Backend.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Net.Http.Formatting;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public class HttpClientManager<T, U> : IHttpClientManager<U>
    {

        #region Attributes


        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpClientManager<T>"/> class.
        /// </summary>
        public HttpClientManager() { }

        #endregion


        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether object to realize http client requests.
        /// </summary>
        /// <value></value>
        public HttpClient Client { get; set; }

        #endregion


        #region Methods And Functions
        public async Task<U> Get(Uri url, MediaTypeFormatter mediaTypeFormatter, IList<HttpParamsDto> queryParams, IList<HttpParamsDto> headers = null)
        {
            try 
            {
                string urlParams = url.ToString();

                if (queryParams != null && queryParams.Count > 0)
                {
                    foreach (HttpParamsDto param in queryParams) 
                    {
                        urlParams += param.Key + "=" + param.Value + "&";
                    }
                    urlParams = urlParams.Substring(0, (urlParams.Length - 1));
                }

                U response = default;

                using (this.Client = new HttpClient())
                {
                    if (headers != null && headers.Count > 0)
                    {
                        foreach (HttpParamsDto header in headers)
                        {
                            this.Client.DefaultRequestHeaders.Add(header.Key, header.Value);
                        }
                    }

                    HttpResponseMessage result = await this.Client.GetAsync(new Uri(urlParams));
                    if (result.IsSuccessStatusCode)
                    {
                        response = await result.Content.ReadAsAsync<U>();

                    }
                    else
                    {
                        throw new Exception("Error en la peticion" + result.StatusCode);
                    }
                }
                return response;
            }
            catch (Exception e)
            {
                throw new HttpClientManagerException(e.Message, e);
            }

        }

        public async Task<U> Post(Uri url, MediaTypeFormatter mediaTypeFormatter, AuthenticationHeaderValue authorize, IList<HttpParamsDto> queryParams, IList<HttpParamsDto> headers)
        {
            try
            {
                string urlParams = url.ToString();

                var dict = new Dictionary<string, string>();

                if (queryParams != null && queryParams.Count > 0)
                {
                    foreach (HttpParamsDto param in queryParams)
                    {
                        dict.Add(param.Key, param.Value);
                    }
                }

                using (this.Client = new HttpClient())
                {
                    HttpContent content = new FormUrlEncodedContent(dict);

                    if (headers != null && headers.Count > 0)
                    {
                        foreach (HttpParamsDto header in headers)
                        {
                            this.Client.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);
                        }
                    }

                    content.Headers.Clear();
                    content.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

                    HttpResponseMessage result = await this.Client.PostAsync(new Uri(urlParams), content);

                    if (result.IsSuccessStatusCode)
                    {
                        string resultString = await result.Content.ReadAsStringAsync();
                        U response = JsonConvert.DeserializeObject<U>(resultString);
                        return response;

                    }
                    else
                    {
                        throw new Exception("Error en la peticion" + result.StatusCode);
                    }
                }
                return default(U);
            }
            catch (Exception e)
            {
                throw new HttpClientManagerException(e.Message, e);
            }

        }

        #endregion



    }
}
