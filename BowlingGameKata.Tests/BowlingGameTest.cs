using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameKata.Tests
{
    [TestClass]
    public class BowlingGameTest
    {
        private Game game;

        [TestInitialize]
        public void SetUp()
        {
            game = new Game();
        }

        [TestMethod]
        public void TestGutterGame()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            RollMany(20, 1);


            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void TestOneSpare()
        {
            RollSpare();
            game.Roll(3);
            RollMany(17, 0);

            Assert.AreEqual(16, game.Score());
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.Roll(pins);
            }
        }

        private void RollSpare()
        {
            game.Roll(5);
            game.Roll(5);
        }
    }
}
