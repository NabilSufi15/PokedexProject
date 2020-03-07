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

        //test if loss is between 0 and 5
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

        //test if loss goes out of scope of 0 and 5
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
