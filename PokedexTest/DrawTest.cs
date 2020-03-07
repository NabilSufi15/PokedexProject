using NUnit.Framework;
using Pokedex;

namespace PokedexTest
{
    class DrawTest
    {
        private MiniGameLogic _logic;

        [SetUp]
        public void Setup()
        {
            _logic = new MiniGameLogic();
        }

        //test if draw is valid
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(6)]
        [TestCase(10)]
        [TestCase(45)]
        [TestCase(100)]
        [Test]
        public void ValidDraw(int newDraw)
        {
            _logic.Draw = newDraw;
            Assert.AreEqual(newDraw, _logic.Draw);
        }

    }
}

