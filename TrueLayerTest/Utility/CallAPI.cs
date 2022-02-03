using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TrueLayerPokemon.Library.Utility
{
    public class CallAPI
    {

        /// <summary>
        /// URL of the API.
        /// </summary>
        private string urlApi;

        /// <summary>
        /// URL of the API
        /// Public variable to expone the variable to external to the class.
        /// </summary>
        public string UrlApi
        {
            get
            {
                return urlApi;
            }

            set
            {
                urlApi = value;
            }
        }


        /// <summary>
        /// Parameter of the URL.
        /// </summary>
        private string parametrApi;

        /// <summary>
        /// Parameter of the URL.
        /// Public variable to expone the variable to external to the class.
        /// </summary>
        public string ParameterApi
        {
            get
            {
                return parametrApi;
            }

            set
            {
                parametrApi = value;
            }
        }


        /// <summary>
        /// Generic method to call an API and return a JSON string.
        /// </summary>
        /// <param name="text">The value to give to the parameter value of the URL</param>
        /// <returns>The JSON string of the API.</returns>
        public string CallUrl(string text)
        {
            string jsonString = string.Empty;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(this.urlApi);

                    string urlParameter = string.Concat(this.parametrApi, text);
                    urlParameter = Uri.EscapeUriString(urlParameter);

                    // Add an Accept header for JSON format.
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // List data response.
                    
                    HttpResponseMessage response = client.GetAsync(urlParameter).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
                    if (response.IsSuccessStatusCode)
                    {
                        // Parse the response body.
                        jsonString = response.Content.ReadAsStringAsync().Result;
                    }
                    else
                    {
                        throw new Exception(Constant.ERROR_MESSAGE_DEFAULT);
                    }

                }
            }
            catch (Exception e)
            {
                jsonString = e.Message;
            }

            return jsonString;
        }

    }
}
