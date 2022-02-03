using Newtonsoft.Json;
using TrueLayerPokemon.Library.Model;
using TrueLayerPokemon.Library.Utility;
using static TrueLayerPokemon.Library.Model.ShakespeareModel;

namespace TrueLayerPokemon.Library.ShakespeareController
{
    public class ShakespeareAPI : CallAPI
    {

        /// <summary>
        /// Constraction of <see cref="ShakespeareAPI"/>.
        /// </summary>
        /// <param name="funtranslationAPI">The API end point to call.</param>
        /// <param name="parameterAPI">The parameter to give to the API end point.</param>
        public ShakespeareAPI(string funtranslationAPI, string parameterAPI)
        {
            this.UrlApi = funtranslationAPI;
            this.ParameterApi = parameterAPI;
        }

        /// <summary>
        /// Call the API to Shakespeare API
        /// </summary>
        /// <param name="text">the value to pass in input to querystring</param>
        /// <returns>The Json</returns>
        public string CallShakespeareAPI(string text)
        {
            string json = this.CallUrl(text);
            return json;
        }

        /// <summary>
        /// Get the translation of the text in Shakespeare Language.
        /// </summary>
        /// <param name="text">Text to translate.</param>
        /// <returns>The text translated in Shakespeare.</returns>
        public string GetShakespeareTranslation(string text)
        {                             
            string json = this.CallShakespeareAPI(text);
            if (! string.Equals(json, "0"))
            {
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);
                string translated = myDeserializedClass.contents.translated;
                return translated;
            }
          
            return json;
        }
    }
}
