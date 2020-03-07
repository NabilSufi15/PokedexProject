using NUnit.Framework;
using Pokedex;

namespace PokedexTest
{
    class ChoiceTest
    {
        private MiniGameLogic _logic;

        [SetUp]
        public void Setup()
        {
            _logic = new MiniGameLogic();
        }

        //test if cpu choice is valid
        [TestCase("water")]
        [TestCase("fire")]
        [TestCase("grass")]
        [Test]
        public void ValidCpuChoice(string newChoice)
        {
            _logic.CpuChoice = newChoice;
            Assert.AreEqual(newChoice, _logic.CpuChoice);
        }

        //test if user choice is valid
        [TestCase("water")]
        [TestCase("fire")]
        [TestCase("grass")]
        [Test]
        public void ValidUserChoice(string newChoice)
        {
            _logic.UserChoice = newChoice;
            Assert.AreEqual(newChoice, _logic.UserChoice);
        }
    }
}
