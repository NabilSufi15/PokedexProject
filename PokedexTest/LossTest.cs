using NUnit.Framework;
using Pokedex;

namespace PokedexTest
{
    class LossTest
    {
        private MiniGameLogic _logic;

        [SetUp]
        public void Setup()
        {
            _logic = new MiniGameLogic();
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [Test]
        public void ValidLoss(int newLoss)
        {
            _logic.Loss = newLoss;
            Assert.AreEqual(newLoss, _logic.Loss);
        }

        [TestCase(-1)]
        [TestCase(6)]
        [Test]
        public void InvalidLoss(int newLoss)
        {
            // arrange
            _logic.Loss = 4;
            // act
            _logic.Loss = newLoss;
            // assert
            Assert.AreEqual(4, _logic.Loss);
        }
    }
}
