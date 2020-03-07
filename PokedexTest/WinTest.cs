using NUnit.Framework;
using Pokedex;

namespace PokedexTest
{
    public class WinTest
    {
        private MiniGameLogic _logic; 

        [SetUp]
        public void Setup()
        {
            _logic = new MiniGameLogic();
        }

        // test if wins is between 0 and 5
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [Test]
        public void ValidWins(int newWins)
        {
            _logic.Wins = newWins;
            Assert.AreEqual(newWins, _logic.Wins);
        }

        //test if wins go outside the scope of 0 and 5
        [TestCase(-1)]
        [TestCase(6)]
        [Test]
        public void InvalidWins(int newWins)
        {
            // arrange
            _logic.Wins = 2;
            // act
            _logic.Wins = newWins;
            // assert
            Assert.AreEqual(2, _logic.Wins);
        }

    }
}