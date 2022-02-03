using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TrueLayerPokemon.Library.PokemonController;
using TrueLayerPokemon.Library.ShakespeareController;
using TrueLayerPokemon.Library.Utility;
using TrueLayerPokemon.WebAPI.Model;

namespace TrueLayerPokemon.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public PokemonController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /// <summary>
        /// The data of the pokemon.
        /// </summary>
        /// <param name="pokemonName">The pokemon name.</param>
        /// <returns><see cref="PokemonModel"/>.</returns>
        [HttpGet]
        public JsonResult GetGetPokemonData(string pokemonName)
        {
            //string pokemonName = "charizard";
            PokemonAPI pokemonApi = new PokemonAPI(Constant.POKEMON_API);
            string pokemonDescription = pokemonApi.GetDescriptionPokemon(pokemonName);

            string shakespeareTranslation = this.GetDescritptionTranslate(pokemonDescription);

            PokemonModel pokemon = new PokemonModel();
            pokemon.PokemonName = pokemonName;
            pokemon.Descritpion = pokemonDescription;
            pokemon.DescritpionShakespeare = shakespeareTranslation;
            return new JsonResult(pokemon);
        }

        /// <summary>
        /// Get the description of Shakespaere.
        /// </summary>
        /// <param name="pokemonDescription">Description of the pokemon</param>
        /// <returns>The description in Shakespeare but if it is not possible the original description.</returns>
        public string GetDescritptionTranslate(string pokemonDescription)
        {
            ShakespeareAPI shakespeareAPI = new ShakespeareAPI(Constant.SHAKESPEARE_API, Constant.PARAMETER_SHAKESPEARE_API);
            string shakespeareTranslation = shakespeareAPI.GetShakespeareTranslation(pokemonDescription);

            if (string.Equals(shakespeareTranslation, Constant.ERROR_MESSAGE_DEFAULT))
            {
                return pokemonDescription;
            }

            return pokemonDescription;

        }

       
    }
}
