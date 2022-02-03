using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueLayerPokemon.Library.Utility
{
    public static class Constant
    {
        /// <summary>
        /// The readonly variable that contains the API to call to translate the text.
        /// </summary>
        public const string POKEMON_API = "https://pokeapi.co/api/v2/pokemon-species/";

        /// <summary>
        /// The readonly variable that contains the API to call to translate the text.
        /// </summary>
        public const string SHAKESPEARE_API = "https://api.funtranslations.com/translate/shakespeare.json";

        /// <summary>
        /// The readonly variable that has been inizialized with the URL parameter for the API.
        /// </summary>
        public const string PARAMETER_SHAKESPEARE_API = "?text=";

        /// <summary>
        /// The string to handle the errors in generic way.
        /// </summary>
        public const string ERROR_MESSAGE_DEFAULT = "0";
    }
}
