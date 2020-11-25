using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameKata.Tests
{
    [TestClass]
    public class BowlingGameTest
    {
        [TestMethod]
        public void TestGutterGame()
        {
            Game game = new Game();
            for (int i = 0; i < 20; i++)
            {
                game.roll(0);
            }

            Assert.AreEqual(0, game.score());
        }
    }
}
