using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueLayerPokemon.Library.ShakespeareController;
using TrueLayerPokemon.Library.Utility;

namespace TrueLayerPokemon.UniteTest
{
    [TestClass]
    public class ShakespeareAPITest
    {
        
        /// <summary>
        /// Success Test.
        /// </summary>
        [TestMethod]
        public void CallShakespeareAPISuccess()
        {
            ShakespeareAPI shakespeareClass = new ShakespeareAPI(Constant.SHAKESPEARE_API, Constant.PARAMETER_SHAKESPEARE_API);
            string result = shakespeareClass.GetShakespeareTranslation("You gave Mr. Tim a hearty meal, but unfortunately what he ate made him die.");
            string expectedResult = "Thee did giveth mr. Tim a hearty meal,  but unfortunately what he did doth englut did maketh him kicketh the bucket.";
            Assert.AreEqual(result, expectedResult);
        }

        /// <summary>
        /// Failure Test
        /// </summary>
        [TestMethod]
        public void CallShakespeareAPIFailures()
        {
            ShakespeareAPI shakespeareClass = new ShakespeareAPI(Constant.SHAKESPEARE_API, Constant.PARAMETER_SHAKESPEARE_API);
            string result = shakespeareClass.GetShakespeareTranslation("Spits fire that\nis hot enough to\nmelt boulders.\fKnown to cause\nforest fires\nunintentionally.");
            Assert.AreEqual(result, Constant.ERROR_MESSAGE_DEFAULT);

        }
    }
}
