using Newtonsoft.Json;
using System.Linq;
using TrueLayerPokemon.Library.Model;
using TrueLayerPokemon.Library.Utility;
using static TrueLayerTest.Library.Model.PokemonModel;

namespace TrueLayerPokemon.Library.PokemonController
{
    public class PokemonAPI : CallAPI
    {
        /// <summary>
        /// Constraction of <see cref="PokemonAPI"/>.
        /// </summary>
        /// <param name="pokemonAPI">The API end point to call.</param>
        public PokemonAPI(string pokemonAPI)
        {
            this.UrlApi = pokemonAPI;
            this.ParameterApi = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string CallPokemonAPI(string text)
        {
            string json = this.CallUrl(text);
            return json;
        }


        /// <summary>
        /// Get the description of the pokemon given in input.
        /// </summary>
        /// <param name="pokemonName">Pokemon Name.</param>
        /// <returns>the description of the Pokemon</returns>
        public string GetDescriptionPokemon(string pokemonName)
        {
            string json = this.CallPokemonAPI(pokemonName);
            if(json == Constant.ERROR_MESSAGE_DEFAULT)
            {
                return json;
            }
            JsonSerializerSettings settings = new JsonSerializerSettings();
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);
            FlavorTextEntry textEntry = myDeserializedClass.flavor_text_entries.FirstOrDefault();
            return textEntry.flavor_text;
        }        
    }
}
