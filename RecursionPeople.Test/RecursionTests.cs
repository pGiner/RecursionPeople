using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RecursionPeople.Test
{
    [TestClass]
    public class RecursionTests
    {
        /// <summary>
        /// Test for the basic function of the method.
        /// </summary>
        [TestMethod]
        public void BasicTest()
        {
            var s = Recursivity.Saludar("Clara", "Juan");
            List<String> expected = new List<String>();
            expected.Add("Clara");
            expected.Add("Maria");
            expected.Add("Fernando");
            expected.Add("Juan");

            for(int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(s[i], expected[i]);
            }
        }

        /// <summary>
        /// Test to check if a person isnt in the list
        /// </summary>
        [TestMethod]
        public void PersonNotFoundTest()
        {
            Assert.ThrowsException<Exception>(() => Recursivity.Saludar("Eusebio", "Juan"));
            Assert.ThrowsException<Exception>(() => Recursivity.Saludar("Clara", "Paquito"));
        }

        /// <summary>
        /// Test to check if the chain of greetings between 2 nmames is broken
        /// </summary>
        [TestMethod]
        public void BrokenSaluteChainTest()
        {
            Assert.ThrowsException<Exception>(() => Recursivity.Saludar("Raul", "Juan"));
        }
    }
}
