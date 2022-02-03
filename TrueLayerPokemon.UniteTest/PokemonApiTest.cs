using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TrueLayerPokemon.Library.PokemonController;
using TrueLayerPokemon.Library.Utility;

namespace TrueLayerPokemon.UniteTest
{
    [TestClass]
    public class PokemonAPITest
    {
       
        /// <summary>
        /// Name of the pokemon to use as test.
        /// </summary>
        private readonly string pokemonName = "charizard";

        //[TestMethod]
        //public void CallPokemonAPISuccess()
        //{
        //    PokemonAPI shakespeareClass = new PokemonAPI(pokemonAPI);
        //    string result = shakespeareClass.CallPokemonAPI("charizard");
        //    Assert.Equals(result, "Spits fire that\nis hot enough to\nmelt boulders.\fKnown to cause\nforest fires\nunintentionally.");
        //}

        [TestMethod]
        public void GetDescriptionPokemonSuccess()
        {
            PokemonAPI shakespeareClass = new PokemonAPI(Constant.POKEMON_API);
            string result = shakespeareClass.GetDescriptionPokemon(pokemonName);
            string expectedResult = "Spits fire that\nis hot enough to\nmelt boulders.\fKnown to cause\nforest fires\nunintentionally.";
            Assert.AreEqual(result, expectedResult);
        }

    }
}
