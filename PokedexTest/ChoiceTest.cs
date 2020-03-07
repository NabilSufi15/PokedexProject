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

        [TestCase("water")]
        [TestCase("fire")]
        [TestCase("grass")]
        [Test]
        public void ValidCpuChoice(string newChoice)
        {
            _logic.CpuChoice = newChoice;
            Assert.AreEqual(newChoice, _logic.CpuChoice);
        }

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
